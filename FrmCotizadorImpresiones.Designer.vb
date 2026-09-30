' Archivo de definición visual del Caso 2.
Namespace PRO205.Semana7.Caso2.CotizadorImpresiones.VB
    ' Marca el código asociado al diseñador.
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class FrmCotizadorImpresiones
        ' Contenedor de Timer y ErrorProvider.
        Private components As System.ComponentModel.IContainer

        ' Libera recursos administrados.
        Protected Overrides Sub Dispose(disposing As Boolean)
            ' Libera componentes cuando corresponde.
            If disposing AndAlso components IsNot Nothing Then
                ' Libera el contenedor.
                components.Dispose()
            End If
            ' Permite que Form libere sus recursos.
            MyBase.Dispose(disposing)
        End Sub

        ' Crea controles, define propiedades y prepara eventos usados mediante Handles.
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            layoutMain = New System.Windows.Forms.TableLayoutPanel()
            lblTitulo = New System.Windows.Forms.Label()
            lblPaginas = New System.Windows.Forms.Label()
            nudPaginas = New System.Windows.Forms.NumericUpDown()
            lblTipo = New System.Windows.Forms.Label()
            cboTipoImpresion = New System.Windows.Forms.ComboBox()
            lblPapel = New System.Windows.Forms.Label()
            cboPapel = New System.Windows.Forms.ComboBox()
            chkDobleFaz = New System.Windows.Forms.CheckBox()
            lblVistaPrevia = New System.Windows.Forms.Label()
            lblTotal = New System.Windows.Forms.Label()
            panelBotones = New System.Windows.Forms.FlowLayoutPanel()
            btnCalcular = New System.Windows.Forms.Button()
            btnLimpiar = New System.Windows.Forms.Button()
            lblHora = New System.Windows.Forms.Label()
            lblEstado = New System.Windows.Forms.Label()
            timerReloj = New System.Windows.Forms.Timer(components)
            errorProvider = New System.Windows.Forms.ErrorProvider(components)
            layoutMain.SuspendLayout()
            CType(nudPaginas, ComponentModel.ISupportInitialize).BeginInit()
            panelBotones.SuspendLayout()
            CType(errorProvider, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' layoutMain
            ' 
            layoutMain.ColumnCount = 2
            layoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F))
            layoutMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            layoutMain.Controls.Add(lblTitulo, 0, 0)
            layoutMain.Controls.Add(lblPaginas, 0, 1)
            layoutMain.Controls.Add(nudPaginas, 1, 1)
            layoutMain.Controls.Add(lblTipo, 0, 2)
            layoutMain.Controls.Add(cboTipoImpresion, 1, 2)
            layoutMain.Controls.Add(lblPapel, 0, 3)
            layoutMain.Controls.Add(cboPapel, 1, 3)
            layoutMain.Controls.Add(chkDobleFaz, 1, 4)
            layoutMain.Controls.Add(lblVistaPrevia, 0, 5)
            layoutMain.Controls.Add(lblTotal, 0, 6)
            layoutMain.Controls.Add(panelBotones, 1, 7)
            layoutMain.Dock = System.Windows.Forms.DockStyle.Fill
            layoutMain.Location = New System.Drawing.Point(0, 33)
            layoutMain.Name = "layoutMain"
            layoutMain.Padding = New System.Windows.Forms.Padding(18)
            layoutMain.RowCount = 8
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
            layoutMain.Size = New System.Drawing.Size(720, 398)
            layoutMain.TabIndex = 0
            ' 
            ' lblTitulo
            ' 
            lblTitulo.AutoSize = True
            layoutMain.SetColumnSpan(lblTitulo, 2)
            lblTitulo.Font = New System.Drawing.Font("Segoe UI", 16F, Drawing.FontStyle.Bold)
            lblTitulo.Location = New System.Drawing.Point(21, 21)
            lblTitulo.Margin = New System.Windows.Forms.Padding(3, 3, 3, 14)
            lblTitulo.Name = "lblTitulo"
            lblTitulo.Size = New System.Drawing.Size(366, 30)
            lblTitulo.TabIndex = 0
            lblTitulo.Text = "Caso 2 - Cotizador de impresiones"
            ' 
            ' lblPaginas
            ' 
            lblPaginas.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblPaginas.AutoSize = True
            lblPaginas.Location = New System.Drawing.Point(21, 71)
            lblPaginas.Name = "lblPaginas"
            lblPaginas.Size = New System.Drawing.Size(137, 19)
            lblPaginas.TabIndex = 1
            lblPaginas.Text = "Cantidad de páginas:"
            ' 
            ' nudPaginas
            ' 
            nudPaginas.Location = New System.Drawing.Point(201, 68)
            nudPaginas.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
            nudPaginas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            nudPaginas.Name = "nudPaginas"
            nudPaginas.Size = New System.Drawing.Size(120, 25)
            nudPaginas.TabIndex = 2
            nudPaginas.Value = New Decimal(New Integer() {1, 0, 0, 0})
            ' 
            ' lblTipo
            ' 
            lblTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblTipo.AutoSize = True
            lblTipo.Location = New System.Drawing.Point(21, 102)
            lblTipo.Name = "lblTipo"
            lblTipo.Size = New System.Drawing.Size(121, 19)
            lblTipo.TabIndex = 3
            lblTipo.Text = "Tipo de impresión:"
            ' 
            ' cboTipoImpresion
            ' 
            cboTipoImpresion.Dock = System.Windows.Forms.DockStyle.Fill
            cboTipoImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboTipoImpresion.Location = New System.Drawing.Point(201, 99)
            cboTipoImpresion.Name = "cboTipoImpresion"
            cboTipoImpresion.Size = New System.Drawing.Size(498, 25)
            cboTipoImpresion.TabIndex = 4
            ' 
            ' lblPapel
            ' 
            lblPapel.Anchor = System.Windows.Forms.AnchorStyles.Left
            lblPapel.AutoSize = True
            lblPapel.Location = New System.Drawing.Point(21, 133)
            lblPapel.Name = "lblPapel"
            lblPapel.Size = New System.Drawing.Size(45, 19)
            lblPapel.TabIndex = 5
            lblPapel.Text = "Papel:"
            ' 
            ' cboPapel
            ' 
            cboPapel.Dock = System.Windows.Forms.DockStyle.Fill
            cboPapel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            cboPapel.Location = New System.Drawing.Point(201, 130)
            cboPapel.Name = "cboPapel"
            cboPapel.Size = New System.Drawing.Size(498, 25)
            cboPapel.TabIndex = 6
            ' 
            ' chkDobleFaz
            ' 
            chkDobleFaz.AutoSize = True
            chkDobleFaz.Location = New System.Drawing.Point(201, 161)
            chkDobleFaz.Name = "chkDobleFaz"
            chkDobleFaz.Size = New System.Drawing.Size(312, 23)
            chkDobleFaz.TabIndex = 7
            chkDobleFaz.Text = "Impresión doble faz (descuento didáctico 10%)"
            ' 
            ' lblVistaPrevia
            ' 
            lblVistaPrevia.AutoSize = True
            layoutMain.SetColumnSpan(lblVistaPrevia, 2)
            lblVistaPrevia.Location = New System.Drawing.Point(21, 187)
            lblVistaPrevia.Name = "lblVistaPrevia"
            lblVistaPrevia.Padding = New System.Windows.Forms.Padding(0, 10, 0, 6)
            lblVistaPrevia.Size = New System.Drawing.Size(83, 35)
            lblVistaPrevia.TabIndex = 8
            lblVistaPrevia.Text = "Vista previa:"
            ' 
            ' lblTotal
            ' 
            lblTotal.AutoSize = True
            layoutMain.SetColumnSpan(lblTotal, 2)
            lblTotal.Font = New System.Drawing.Font("Segoe UI", 15F, Drawing.FontStyle.Bold)
            lblTotal.Location = New System.Drawing.Point(21, 222)
            lblTotal.Name = "lblTotal"
            lblTotal.Size = New System.Drawing.Size(94, 28)
            lblTotal.TabIndex = 9
            lblTotal.Text = "Total: $0"
            ' 
            ' panelBotones
            ' 
            panelBotones.AutoSize = True
            panelBotones.Controls.Add(btnCalcular)
            panelBotones.Controls.Add(btnLimpiar)
            panelBotones.Location = New System.Drawing.Point(201, 253)
            panelBotones.Name = "panelBotones"
            panelBotones.Size = New System.Drawing.Size(218, 35)
            panelBotones.TabIndex = 10
            ' 
            ' btnCalcular
            ' 
            btnCalcular.AutoSize = True
            btnCalcular.Location = New System.Drawing.Point(3, 3)
            btnCalcular.Name = "btnCalcular"
            btnCalcular.Size = New System.Drawing.Size(131, 29)
            btnCalcular.TabIndex = 0
            btnCalcular.Text = "Calcular cotización"
            ' 
            ' btnLimpiar
            ' 
            btnLimpiar.AutoSize = True
            btnLimpiar.Location = New System.Drawing.Point(140, 3)
            btnLimpiar.Name = "btnLimpiar"
            btnLimpiar.Size = New System.Drawing.Size(75, 29)
            btnLimpiar.TabIndex = 1
            btnLimpiar.Text = "Limpiar"
            ' 
            ' lblHora
            ' 
            lblHora.AutoSize = True
            lblHora.Dock = System.Windows.Forms.DockStyle.Top
            lblHora.Location = New System.Drawing.Point(0, 0)
            lblHora.Name = "lblHora"
            lblHora.Padding = New System.Windows.Forms.Padding(18, 10, 18, 4)
            lblHora.Size = New System.Drawing.Size(150, 33)
            lblHora.TabIndex = 1
            lblHora.Text = "Hora del sistema:"
            ' 
            ' lblEstado
            ' 
            lblEstado.AutoSize = True
            lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom
            lblEstado.Location = New System.Drawing.Point(0, 431)
            lblEstado.Name = "lblEstado"
            lblEstado.Padding = New System.Windows.Forms.Padding(18, 8, 18, 12)
            lblEstado.Size = New System.Drawing.Size(285, 39)
            lblEstado.TabIndex = 2
            lblEstado.Text = "Seleccione las opciones de la cotización."
            ' 
            ' timerReloj
            ' 
            timerReloj.Interval = 1000
            ' 
            ' errorProvider
            ' 
            errorProvider.ContainerControl = Me
            ' 
            ' FrmCotizadorImpresiones
            ' 
            AutoScaleDimensions = New System.Drawing.SizeF(7F, 17F)
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            ClientSize = New System.Drawing.Size(720, 470)
            Controls.Add(layoutMain)
            Controls.Add(lblHora)
            Controls.Add(lblEstado)
            Font = New System.Drawing.Font("Segoe UI", 10F)
            MinimumSize = New System.Drawing.Size(660, 430)
            Name = "FrmCotizadorImpresiones"
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Text = "[PRO205] Caso 2: Cotizador de impresiones"
            layoutMain.ResumeLayout(False)
            layoutMain.PerformLayout()
            CType(nudPaginas, ComponentModel.ISupportInitialize).EndInit()
            panelBotones.ResumeLayout(False)
            panelBotones.PerformLayout()
            CType(errorProvider, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()
        End Sub

        ' Declara controles; WithEvents permite usar Handles.
        Private layoutMain As System.Windows.Forms.TableLayoutPanel
        Private lblTitulo As System.Windows.Forms.Label
        Private lblPaginas As System.Windows.Forms.Label
        Private WithEvents nudPaginas As System.Windows.Forms.NumericUpDown
        Private lblTipo As System.Windows.Forms.Label
        Private WithEvents cboTipoImpresion As System.Windows.Forms.ComboBox
        Private lblPapel As System.Windows.Forms.Label
        Private WithEvents cboPapel As System.Windows.Forms.ComboBox
        Private WithEvents chkDobleFaz As System.Windows.Forms.CheckBox
        Private lblVistaPrevia As System.Windows.Forms.Label
        Private lblTotal As System.Windows.Forms.Label
        Private panelBotones As System.Windows.Forms.FlowLayoutPanel
        Private WithEvents btnCalcular As System.Windows.Forms.Button
        Private WithEvents btnLimpiar As System.Windows.Forms.Button
        Private lblHora As System.Windows.Forms.Label
        Private lblEstado As System.Windows.Forms.Label
        Private WithEvents timerReloj As System.Windows.Forms.Timer
        Private errorProvider As System.Windows.Forms.ErrorProvider
    End Class
End Namespace
