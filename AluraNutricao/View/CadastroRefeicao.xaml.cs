using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace AluraNutricao {

	public partial class CadastroRefeicao : ContentPage {

		public CadastroRefeicao(RefeicaoDAO dao) {
			CadastroRefeicaoViewModel vm = new CadastroRefeicaoViewModel(dao, this);
			BindingContext = vm;
			InitializeComponent();
		}

	}
}
