using System;
using System.IO;
using AluraNutricao.iOS;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_ios))]
namespace AluraNutricao.iOS {
	public class SQLite_ios : ISqlite {

		public SQLiteConnection GetConnection() {

			var filename = "Refeicoes.db3";
			var documents = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			var path = Path.Combine(documents, "..", "Library", filename);

			return new SQLiteConnection(path);
		}
	}
}
