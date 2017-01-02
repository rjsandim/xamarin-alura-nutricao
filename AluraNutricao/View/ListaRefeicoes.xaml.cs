using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNutricao {
	public partial class ListaRefeicoes : ContentPage {

		public ObservableCollection<Refeicao> Refeicoes { get; set; }
		RefeicaoDAO dao;
		public string Nome { get; set; }

		public ListaRefeicoes(RefeicaoDAO dao) {
			Nome = "Alura";
			BindingContext = this;
			this.dao = dao;
			Refeicoes = dao.Lista;

			InitializeComponent();

		}

		public async void AcaoItem(Object sender, ItemTappedEventArgs e) {
			Refeicao refeicao = e.Item as Refeicao;

			var resposta = await DisplayAlert("Remover Item", "Tem certeza que deseja remover: " + refeicao.Descricao, "Sim", "Nao");

			if (resposta) {
				dao.Remove(refeicao);
				await DisplayAlert("Remover Item", "Refeicao removida com sucesso!", "Ok");
			}
		}
	}
}
