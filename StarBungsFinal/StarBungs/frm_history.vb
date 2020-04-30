Public Class frm_history
    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_history.CellContentClick

    End Sub

    Public Sub load_coffee()
        connect_open()


        sql = "select C.coffeeName Name,sum(S.coffeeAmount) Quantity,sum(S.coffeeTotal) Total from coffee C inner join sales S on C.coffeeID = S.coffeeID group by C.coffeeName ORDER BY SUM(S.coffeeAmount) DESC "
        'sql = "select saleFullID,coffeeID,coffeeAmount,coffeeTotal from sales"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_history.DataSource = DS.Tables("table")


    End Sub
    Public Sub load_customer()
        connect_open()



        sql = "select D.customer Name,sum(S.coffeeAmount) Quantity,sum(D.sale_net) Total from sale_details D inner join sales S on D.saleFullID = S.saleFullID group by D.customer order by sum(S.coffeeAmount) DESC"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_history.DataSource = DS.Tables("table")


    End Sub

    Public Sub load_staff()
        connect_open()



        sql = "select D.staff Name,sum(S.coffeeAmount) Quantity,sum(D.sale_net) Total from sale_details D inner join sales S on D.saleFullID = S.saleFullID group by D.staff order by sum(S.coffeeAmount) DESC"
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_history.DataSource = DS.Tables("table")


    End Sub

    Public Sub load_profit()
        connect_open()



        sql = "select S.date Date,sum(D.sale_net) Profit from sale_details D inner join sales S on D.saleFullID = S.saleFullID group by S.date "
        DA = New SqlClient.SqlDataAdapter(sql, cn)
        DS = New DataSet
        DA.Fill(DS, "table")
        datagrid_history.DataSource = DS.Tables("table")


    End Sub
    Private Sub frm_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        load_coffee()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        load_customer()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        load_staff()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        load_profit()
    End Sub
End Class