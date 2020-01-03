using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BakusaiSearch
{
    class Utility
    {

        public static readonly DataTable DataGridViewBindTable = CreateDataGridViewBindTable();


        public static DataTable CreateDataGridViewBindTable()
        {
            DataTable dataTable = new DataTable();

            InitDataGridViewBindTable(dataTable);

            return dataTable;
        }

        /// <summary>
        /// DataGridViewのデータソースの初期化
        /// </summary>
        public static void InitDataGridViewBindTable(DataTable inDataTable)
        {
            inDataTable.TableName = Define.DATASORCE_TABLE_NAME;
            inDataTable.Columns.Add(Define.PAGR, Type.GetType("System.String"));
            inDataTable.Columns.Add(Define.SEARCH_RESULT, Type.GetType("System.String"));
        }

        public static FileStream FileOpen(string inFilePath, FileMode inMode, FileAccess inAccess, FileShare inShare)
        {
            FileStream fileStream = new FileStream(inFilePath, inMode, inAccess, inShare);

            return fileStream;

        }

        public static void FileClose(FileStream inFileStream)
        {
            if (inFileStream == null)
            {
                return;
            }
            inFileStream.Close();
        }
    }
}
