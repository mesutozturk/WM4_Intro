using MyCoin.Models;
using MyCoin.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MyCoin.Utils;

namespace MyCoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Symbol> _symbols = new List<Symbol>();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var result = new ExchangeInfoService().Result();
                _symbols = result.Symbols;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            _symbols = _symbols
                .Where(x => x.status == "TRADING")
                .OrderBy(x => x.symbol)
                .ToList();

            lstExchangeInfo.DataSource = _symbols;
            lstExchangeInfo.DisplayMember = nameof(Symbol.symbol);

            this.Text = $"{_symbols.Count} Adet Coin Listelenmektedir.";
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAra.Text))
            {
                lstExchangeInfo.DataSource = _symbols;
                this.Text = $"{_symbols.Count} Adet Coin Listelenmektedir.";
            }
            else
            {
                var result = _symbols.Where(x => x.symbol.Contains(txtAra.Text.ToUpper())).ToList();
                lstExchangeInfo.DataSource = result;
                this.Text = $"{result.Count} Adet Coin Listelenmektedir.";
            }
        }

        private Symbol _seciliSymbol;
        private void lstExchangeInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstExchangeInfo.SelectedItem == null) return;

            _seciliSymbol = lstExchangeInfo.SelectedItem as Symbol;
            GetCoinInfo();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(_seciliSymbol == null) return;

            GetCoinInfo();
        }

        private void GetCoinInfo()
        {
            try
            {
                var result = new SymbolTickerService().Result(_seciliSymbol.symbol);

                lblSymbol.Text = result.Symbol;
                lblFiyat.Text = $"{result.LastPrice}\n{result.PriceChangePercent / 100:P}";
                lblFiyat.ForeColor = result.PriceChange > 0 ? Color.LimeGreen : Color.Tomato;
                lblInfo.Text =
                    $"Açılış:{result.OpenPrice}\nEn Düşük: {result.LowPrice}\nEn Yüksek: {result.HighPrice}\nAçılış: {BinanceHelper.DateConverter(result.OpenTime)}\nKapanış: {BinanceHelper.DateConverter(result.CloseTime)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}