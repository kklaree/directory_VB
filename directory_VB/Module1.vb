Module Module1
    Dim Emp_Dir As New Dictionary(Of Integer, String)
    Dim Emp_ID As Integer
    Dim Emp_Name As String
    Sub AddEmp()
        Try
            Console.WriteLine("")
            Console.WriteLine("")
            Console.Write("   Input Employee ID number: ")
            Emp_ID = Console.ReadLine()
            Console.Write("   Input Employee Name: ")
            Emp_Name = Console.ReadLine()
            Emp_Dir.Add(Emp_ID, Emp_Name)
            Menu()
        Catch ex As Exception
            Console.WriteLine("")
            Console.WriteLine("   An error occured: " & ex.Message)
            Console.WriteLine("")
            Console.WriteLine("   Press any key to try again")
            Console.ReadKey()
            Console.Clear()
            Menu()
        End Try

    End Sub
    Sub Display()
        Console.WriteLine("   List of Employees:")
        Console.WriteLine("")
        For Each item As KeyValuePair(Of Integer, String) In Emp_Dir
            Console.WriteLine("        Employee ID: " & item.Key & "; Employee Name: " & item.Value)
        Next
    End Sub
    Sub Remove()
        Console.WriteLine("")
        Console.Write("   Enter Employee ID you wish to remove: ")
        Emp_ID = Console.ReadLine()
        Emp_Dir.Remove(Emp_ID)
        Menu()
    End Sub
    Sub Search()
        Console.WriteLine("")
        Console.Write("   Enter Employee ID you wish to find: ")
        Emp_ID = Console.ReadLine()
        Console.WriteLine("        Employee ID: " & Emp_Dir.ContainsKey(Emp_ID) & "; Employee Name: " & Emp_Dir.ContainsKey(Emp_Name))
        Console.ReadKey()
        Menu()
    End Sub
    Sub Menu()
        Try
            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("   Employee Directory")
            Console.WriteLine("")
            Console.WriteLine("        [1] Add Employee")
            Console.WriteLine("        [2] Remove Employee")
            Console.WriteLine("        [3] Search Employee")
            Console.WriteLine("        [4] Exit")
            Console.WriteLine("")

            Display()

            Console.WriteLine("")
            Console.Write("   Enter number of choice: ")
            Dim opt As Integer = Console.ReadLine()

            If opt = 1 Then
                AddEmp()
            ElseIf opt = 2 Then
                Remove()
            ElseIf opt = 3 Then
                Search()
            ElseIf opt = 4 Then
                Environment.Exit(0)
            Else
                Console.WriteLine("")
                Console.WriteLine("   Invalid input. Please try again.")
                Console.ReadKey()
                Console.Clear()
                Menu()
            End If

        Catch ex As Exception
            Console.WriteLine("   An error occured: " & ex.Message)
            Console.WriteLine("")
            Console.WriteLine("   Press any key to try again")
            Console.ReadKey()
            Console.Clear()
            Menu()
        End Try
    End Sub
    Sub Main()
        Menu()
    End Sub

End Module
