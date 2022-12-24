Public Class Frm_Principal

    Public frm As New Form

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2AnimateWindow1.SetAnimateWindow(Me)
        Guna2ShadowForm1.SetShadowForm(Me)

        pnl_Principal.Location = New Point(0, 52)
        pnl_Login.Location = New Point(148, 114)
        trs_Aparecer.WaitAllAnimations()
        lb_Bienvenida.Visible = False
        trs_Aparecer.Show(pnl_Login)

    End Sub

    Private Sub lb_Quitar_Click(sender As Object, e As EventArgs) Handles lb_Quitar.Click
        End
    End Sub

    Private Sub lb_Minimizar_Click(sender As Object, e As EventArgs) Handles lb_Minimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_Salir_Click(sender As Object, e As EventArgs) Handles btn_CerrarS.Click
        pnl_Menu.Enabled = False
        pnl_Principal.Visible = False
        pnl_Contenedor.Visible = False
        trs_Aparecer.Show(pnl_Login)
        trs_Aparecer.WaitAllAnimations()
        txt_DNI.Focus()
    End Sub

    Private Sub btn_IniciarS_Click(sender As Object, e As EventArgs) Handles btn_IniciarS.Click
        pnl_Login.Visible = False
        trs_Aparecer.Show(pnl_Principal)
        tmr_Iniciar.Enabled = True
    End Sub

    Private Sub btn_Home_Click(sender As Object, e As EventArgs) Handles btn_Home.Click
        Mostrar_Home()
    End Sub

    Private Sub Mostrar_Home()
        frm.Dispose()
        pnl_Contenedor.Visible = False
        pnl_Contenedor.Controls.Clear()
        frm = Frm_Personas
        frm.TopLevel = False
        frm.Show()
        frm.Dock = DockStyle.Fill
        pnl_Contenedor.Controls.Add(frm)
        trs_Aparecer.Show(pnl_Contenedor)
    End Sub

    Private Sub Mostrar_Equipos()
        frm.Dispose()
        pnl_Contenedor.Visible = False
        pnl_Contenedor.Controls.Clear()
        frm = Frm_Personas
        Frm_Personas.Label1.Text = "Todo bien?"
        frm.TopLevel = False
        frm.Show()
        frm.Dock = DockStyle.Fill
        pnl_Contenedor.Controls.Add(frm)
        trs_Aparecer.Show(pnl_Contenedor)
    End Sub

    Private Sub tmr_Iniciar_Tick(sender As Object, e As EventArgs) Handles tmr_Iniciar.Tick
        trs_Aparecer.WaitAllAnimations()
        pnl_Menu.Enabled = True
        btn_Home.PerformClick()
        tmr_Iniciar.Dispose()
    End Sub

    Private Sub btn_Equipos_Click(sender As Object, e As EventArgs) Handles btn_Equipos.Click
        Mostrar_Equipos()
    End Sub
End Class