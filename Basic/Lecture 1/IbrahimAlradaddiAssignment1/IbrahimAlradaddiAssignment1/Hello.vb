Module Hello


    Sub Main()
        System.Console.WriteLine("Hello World")

        System.Console.Write("Title: ")
        System.Console.WriteLine(My.Application.Info.Title)
        System.Console.Write("Description: ")
        System.Console.WriteLine(My.Application.Info.Description)
        System.Console.Write("Company Name: ")
        System.Console.WriteLine(My.Application.Info.CompanyName)
        System.Console.Write("Product Name: ")
        System.Console.WriteLine(My.Application.Info.ProductName)
        System.Console.Write("Copyright: ")
        System.Console.WriteLine(My.Application.Info.Copyright)
        System.Console.Write("Assembly Version: ")
        System.Console.WriteLine(My.Application.Info.Version)


        System.Console.WriteLine("Please press [Enter] to close.")
        System.Console.ReadLine()

    End Sub


End Module
