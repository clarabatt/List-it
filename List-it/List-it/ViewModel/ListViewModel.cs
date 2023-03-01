using System;
using System.Collections.ObjectModel;
using Listit.Model;

namespace Listit.ViewModel
{
	public class ListViewModel
	{
		public ObservableCollection<Item> ItemsList { get; set; }
		public ListViewModel()
		{
			PopulateList();
			
		}

        private void PopulateList()
        {
			ItemsList = new ObservableCollection<Item>()
			{
				new Item{ Name="Computador", Category="Eletro", Quantity=10 },
                new Item{ Name = "uva", Category = "Mercado", Quantity = 0  },
                new Item{ Name = "Televisao", Category = "Eletro", Quantity = 0  },
                new Item{ Name = "Ferradura", Category = "Ferramenta", Quantity = 0 },
                new Item{ Name = "Remedio", Category = "Saude", Quantity = 0  },
                new Item{ Name = "uva", Category = "Mercado", Quantity = 0  },
                new Item{ Name = "Televisao", Category = "Eletro", Quantity = 0  },
                new Item{ Name = "Ferradura", Category = "Ferramenta", Quantity = 0 },
                new Item{ Name = "Remedio", Category = "Saude", Quantity = 0  }
            };
        }
    }
}

