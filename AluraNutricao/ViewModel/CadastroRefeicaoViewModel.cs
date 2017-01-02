using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AluraNutricao {
	public class CadastroRefeicaoViewModel : INotifyPropertyChanged {

		public event PropertyChangedEventHandler PropertyChanged;

		string descricao;
		double calorias;
		public string Descricao {
			get { return descricao; }
			set {
				if (descricao != value) {
					descricao = value;
					OnPropertyChanged("Descricao");
				}
			}
		}

		public double Calorias {
			get { return calorias; }
			set {
				if (calorias != value) {
					calorias = value;
					OnPropertyChanged("Calorias");
				}
			}
		}

		public ICommand SalvarRefeicao { get; protected set; }

		public CadastroRefeicaoViewModel(RefeicaoDAO dao, Page page) {
			
			SalvarRefeicao = new Command(() => {

				Refeicao refeicao = new Refeicao(descricao, calorias);
				dao.Salvar(refeicao);

				string msg = "A Refeicao " + descricao + " de " + calorias + " calorias salvas com sucesso";

				page.DisplayAlert("Salvar Refeicao", msg, "Ok!");

			});
		}

		void OnPropertyChanged(string nome) {
			PropertyChanged(this, new PropertyChangedEventArgs(nome));
		}

	}
}
