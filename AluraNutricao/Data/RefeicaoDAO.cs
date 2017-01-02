using System;
using System.Collections.ObjectModel;
using SQLite;

namespace AluraNutricao {
	public class RefeicaoDAO {

		SQLiteConnection conexao;
		ObservableCollection<Refeicao> lista;
		public ObservableCollection<Refeicao> Lista { 
		
			get {

				if (lista == null) {
					lista = GetAll();
				}
				return lista;
			}
			private set {
				lista = value;
			}
		}

		public RefeicaoDAO(SQLiteConnection con) {
			conexao = con;
			conexao.CreateTable<Refeicao>();
		}

		public void Salvar(Refeicao refeicao) {
			conexao.Insert(refeicao);
			lista.Add(refeicao);
		}

		ObservableCollection<Refeicao> GetAll() {

			return new ObservableCollection<Refeicao>(conexao.Table<Refeicao>());
		}

		public void Remove(Refeicao refeicao) {
			conexao.Delete<Refeicao>(refeicao.Id);
			lista.Remove(refeicao);
		}
	}
}
