Module MDConexcion
    Public conexion As New Microsoft.Data.SqlClient.SqlConnection("data source=HP-ENVY\SQLEXPRESS; initial catalog =Proyecto; integrated security=SSPI; persist security info = false; trusted_connection = yes;")

    'Nos permite ejecutar los comandos que tiene que ver con los procedimientos almacenados de sql

    Public cmd As Microsoft.Data.SqlClient.SqlCommand

    'Permite leer los datos

    Public sqlread As Microsoft.Data.SqlClient.SqlDataReader

    Public Query As String
End Module
