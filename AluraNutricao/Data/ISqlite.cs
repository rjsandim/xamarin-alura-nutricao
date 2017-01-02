using System;
using SQLite;

namespace AluraNutricao {
	public interface ISqlite {
		SQLiteConnection GetConnection();
	}
}
