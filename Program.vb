' Importa tipos base del runtime.
Imports System
' Importa Application y otros tipos Windows Forms.
Imports System.Windows.Forms

' Espacio de nombres del Caso 2.
Namespace PRO205.Semana7.Caso2.CotizadorImpresiones.VB
    ' Módulo que contiene el punto de entrada.
    Friend Module Program
        ' Configura el hilo principal como STA.
        ' Punto de entrada de la aplicación.
        Public Sub Main()
            ' Habilita estilos visuales del sistema.
            Application.EnableVisualStyles()
            ' Mantiene el renderizado de texto compatible.
            Application.SetCompatibleTextRenderingDefault(False)
            ' Inicia el formulario principal.
            Application.Run(New FrmCotizadorImpresiones())
        End Sub
    End Module
End Namespace