' Importa DateTime, Math y EventArgs.
Imports System
' Importa controles y eventos de Windows Forms.
Imports System.Windows.Forms

' Espacio de nombres del Caso 2.
Namespace PRO205.Semana7.Caso2.CotizadorImpresiones.VB
    ' Formulario que calcula una cotización simple.
    <System.ComponentModel.DesignerCategory("Form")>
    Public Partial Class FrmCotizadorImpresiones
        Inherits Form

        ' Constructor.
        Public Sub New()
            ' Construye la interfaz visual.
            InitializeComponent()
        End Sub

        ' Evento del sistema Load.
        Private Sub FrmCotizadorImpresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Carga las modalidades de impresión.
            cboTipoImpresion.Items.AddRange(New Object() {"Blanco y negro", "Color"})
            ' Carga los formatos de papel.
            cboPapel.Items.AddRange(New Object() {"Carta", "Oficio", "A3"})
            ' Define una página como valor inicial.
            nudPaginas.Value = 1D
            ' Inicia el Timer.
            timerReloj.Start()
            ' Actualiza el reloj inmediatamente.
            ActualizarReloj()
            ' Construye la vista previa inicial.
            ActualizarVistaPrevia()
        End Sub

        ' Evento de sistema Timer.Tick.
        Private Sub timerReloj_Tick(sender As Object, e As EventArgs) Handles timerReloj.Tick
            ' Actualiza la hora visible.
            ActualizarReloj()
        End Sub

        ' Método auxiliar para mostrar la hora.
        Private Sub ActualizarReloj()
            ' Obtiene la hora actual y la formatea.
            lblHora.Text = $"Hora del sistema: {DateTime.Now:dd-MM-yyyy HH:mm:ss}"
        End Sub

        ' Evento de usuario: cambia la cantidad de páginas.
        Private Sub nudPaginas_ValueChanged(sender As Object, e As EventArgs) Handles nudPaginas.ValueChanged
            ' Recalcula la vista previa.
            ActualizarVistaPrevia()
        End Sub

        ' Evento de usuario: cambia el tipo de impresión.
        Private Sub cboTipoImpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoImpresion.SelectedIndexChanged
            ' Recalcula la vista previa.
            ActualizarVistaPrevia()
        End Sub

        ' Evento de usuario: cambia el papel.
        Private Sub cboPapel_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPapel.SelectedIndexChanged
            ' Recalcula la vista previa.
            ActualizarVistaPrevia()
        End Sub

        ' Evento de usuario: marca o desmarca doble faz.
        Private Sub chkDobleFaz_CheckedChanged(sender As Object, e As EventArgs) Handles chkDobleFaz.CheckedChanged
            ' Recalcula la vista previa.
            ActualizarVistaPrevia()
        End Sub

        ' Muestra una estimación mientras el usuario completa el formulario.
        Private Sub ActualizarVistaPrevia()
            ' Comprueba que existan selecciones mínimas.
            Dim puedeCalcular As Boolean = cboTipoImpresion.SelectedIndex >= 0 AndAlso cboPapel.SelectedIndex >= 0
            ' Maneja el estado incompleto.
            If Not puedeCalcular Then
                ' Orienta sobre lo que falta.
                lblVistaPrevia.Text = "Vista previa: seleccione tipo de impresión y papel."
                ' Sale sin calcular.
                Return
            End If

            ' Ejecuta la regla de cálculo.
            Dim total As Decimal = CalcularTotal()
            ' Muestra la estimación.
            lblVistaPrevia.Text = $"Vista previa: {nudPaginas.Value} página(s) · Total estimado ${total:N0}"
        End Sub

        ' Encapsula la regla de negocio del precio.
        Private Function CalcularTotal() As Decimal
            ' Selecciona la tarifa según el tipo de impresión.
            Dim precioPorPagina As Decimal = If(cboTipoImpresion.SelectedItem IsNot Nothing AndAlso cboTipoImpresion.SelectedItem.ToString() = "Color", 180D, 40D)
            ' Define el recargo por página según el formato de papel.
            Dim recargoPapel As Decimal = 0D
            Select Case If(cboPapel.SelectedItem?.ToString(), String.Empty)
                Case "Oficio"
                    recargoPapel = 20D
                Case "A3"
                    recargoPapel = 50D
            End Select
            ' Calcula el subtotal.
            Dim subtotal As Decimal = nudPaginas.Value * (precioPorPagina + recargoPapel)
            ' Aplica descuento pedagógico de 10% en doble faz.
            Dim total As Decimal = If(chkDobleFaz.Checked, subtotal * 0.9D, subtotal)
            ' Redondea a pesos completos.
            Return Math.Round(total, 0, MidpointRounding.AwayFromZero)
        End Function

        ' Evento de usuario: clic en Calcular cotización.
        Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
            ' Valida antes de mostrar el total definitivo.
            If Not ValidarFormulario() Then
                ' Sale cuando existe un problema.
                Return
            End If

            ' Calcula el total.
            Dim total As Decimal = CalcularTotal()
            ' Muestra el resultado.
            lblTotal.Text = $"Total: ${total:N0}"
            ' Informa éxito.
            lblEstado.Text = "Cotización calculada correctamente."
        End Sub

        ' Método de validación.
        Private Function ValidarFormulario() As Boolean
            ' Limpia errores anteriores.
            errorProvider.Clear()
            ' Presume que la entrada es válida.
            Dim esValido As Boolean = True

            ' Verifica el tipo de impresión.
            If cboTipoImpresion.SelectedIndex < 0 Then
                ' Identifica la causa.
                errorProvider.SetError(cboTipoImpresion, "Seleccione Blanco y negro o Color.")
                ' Marca inválido.
                esValido = False
            End If

            ' Verifica el papel.
            If cboPapel.SelectedIndex < 0 Then
                ' Identifica la causa.
                errorProvider.SetError(cboPapel, "Seleccione el tamaño de papel.")
                ' Marca inválido.
                esValido = False
            End If

            ' Verifica explícitamente el rango permitido.
            If nudPaginas.Value < 1D OrElse nudPaginas.Value > 500D Then
                ' Explica el rango.
                errorProvider.SetError(nudPaginas, "La cantidad debe estar entre 1 y 500 páginas.")
                ' Marca inválido.
                esValido = False
            End If

            ' Informa estado cuando existe algún error.
            If Not esValido Then
                ' Orienta a revisar controles marcados.
                lblEstado.Text = "No se puede calcular: revise los campos marcados con error."
            End If

            ' Devuelve el resultado.
            Return esValido
        End Function

        ' Evento de usuario: clic en Limpiar.
        Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
            ' Limpia errores.
            errorProvider.Clear()
            ' Restablece páginas.
            nudPaginas.Value = 1D
            ' Quita tipo.
            cboTipoImpresion.SelectedIndex = -1
            ' Quita papel.
            cboPapel.SelectedIndex = -1
            ' Desmarca doble faz.
            chkDobleFaz.Checked = False
            ' Reinicia total.
            lblTotal.Text = "Total: $0"
            ' Actualiza estado.
            lblEstado.Text = "Formulario limpio."
            ' Refresca vista previa.
            ActualizarVistaPrevia()
        End Sub
    End Class
End Namespace