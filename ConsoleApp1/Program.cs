﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int itemPrice = 38;
			try
			{
				Invoice invoice = new Invoice(itemPrice);
				Console.WriteLine(invoice.GetResult());
			}
			catch(Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
	}


	public class Invoice

	{
		private readonly double _rate;
		private int _price;
		public int Price
		{

			get { return _price; }
			set
			{
				if (value <= 0) { throw new Exception("商品價格小於等於0，不用發票"); }
				else{ _price = value; }
			}
		}
		public int Tax { get; private set; }
		public int InclusivePrice { get; private set; }
		

		public Invoice(int price, double taxRate = 0.05)
		{
			this.Price = price;
			_rate = taxRate;
					
		}

		public string GetResult() {
					
			string result = $"商品總金額:{_price},營業稅:{GetTax()}, 發票總額:{GetInclusivePrice()}";
			return result ;
		}

		private int GetTax()
		{
			Tax = (int)Math.Round(_price * _rate, MidpointRounding.AwayFromZero);
			return Tax;
		}
		private int GetInclusivePrice()
		{
			InclusivePrice = _price + GetTax();
			return InclusivePrice;
		}



		//private string errorWarning()
		//{
		//	return "輸入的值小於或等於0，請重新輸入";

		//}

	}

}
