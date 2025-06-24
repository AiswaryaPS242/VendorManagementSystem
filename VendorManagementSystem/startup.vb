Module Startup
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New LoginForm()) ' make sure LoginForm is added to your project
    End Sub
End Module
