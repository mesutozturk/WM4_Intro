using MyCoin.Models;
using MyCoin.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
            var result = new ExchangeInfoService().Result();
            _symbols = result.Symbols;

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
    }
}