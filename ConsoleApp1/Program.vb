Imports System

Module Program
    Private Const PI As Single = 3.1415926535
    Enum Gender
        male
        female
    End Enum
    Structure Student
        Dim name As String
        Dim age As Integer
        Dim sex As Gender
        Sub New(ByVal studentname As String, ByVal studentbirth As Integer, ByVal studentsex As Gender)
            name = studentname
            age = Now.Year - studentbirth
            sex = studentsex
        End Sub
    End Structure
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        '这是注释
        REM 这是注释
        '变量声明
        Dim strName, strGender As String
        strName = "pwx"
        strGender = "男"
        Console.WriteLine(strName) : Console.WriteLine(strGender)
        ' 数字类型
        ' Byte Short/Int16 Integer/Int32 Long/Int64
        ' Single Double
        ' Decimal

        ' 字符类型
        ' Char String
        Dim str, str1 As String
        str = strName & strGender
        str1 = strName + strGender
        Console.WriteLine(str)
        Console.WriteLine(str1)
        Console.WriteLine("长度：" & str.Length)
        str = strName.ToUpper()
        Console.WriteLine(str)
        Console.WriteLine(strName.ToUpper)
        str = "This is a test"
        str1 = str.Substring(5, 4) '索引5开始，截取4个
        Console.WriteLine(str1)
        Dim strBoolean As String = "True"
        Console.WriteLine(CType(strBoolean, Boolean))

        ' 时间
        Dim date1, date2 As Date
        date1 = Now()
        Console.WriteLine(date1)
        date2 = New DateTime(2018, 1, 1, 23, 59, 59)
        Console.WriteLine(date1)
        Console.WriteLine(date1.ToString("yyyy/MM/dd"))
        Console.WriteLine(String.Format(date1, "yyyy/MM/dd HH/mm/ss"))
        Dim tspan As TimeSpan
        tspan = date1.Subtract(date2)
        Console.WriteLine("天数差" & tspan.Days)
        Console.WriteLine("相差天数" & tspan.TotalDays)
        Console.WriteLine("小时差" & tspan.Hours)
        Console.WriteLine("相差小时" & tspan.TotalHours)
        Dim monthDiff As Integer
        monthDiff = DateDiff(DateInterval.Month, date2, date1)
        Console.WriteLine("相差月数" & monthDiff)

        ' 除法
        Console.WriteLine(7 / 2)
        ' 取整
        Console.WriteLine(7 \ 2)
        ' 取余
        Console.WriteLine(7 Mod 2)

        Dim studentInfo As New Student("小明", 1999, Gender.female)
        Console.WriteLine(studentInfo.name & "," & studentInfo.age & "," & studentInfo.sex)
        ' 数组
        Dim people(10) As String
        ReDim people(15) '重新分配数组的大小 会清空数组
        For i As Integer = 0 To 15
            people(i) = "people:" & i.ToString
            Console.WriteLine(people(i))
        Next

        ReDim Preserve people(17) '重新分配 不会清空
        For Each p In people
            Console.WriteLine("Redim Preserve:" & p)
        Next
        ' 多维数组
        Dim students(2, 5) As String
        For i As Integer = 0 To 2
            For j As Integer = 0 To 5
                students(i, j) = (i + 1) & "班" & (j + 1) & "号"
                Console.Write(students(i, j) & " ")
            Next
            Console.WriteLine()
        Next
        Dim arr() As String = {"a", "b", "c"}
        Console.WriteLine(students.Length & " " & students.Rank & " " & students.GetLength(1))

        ' List
        Dim lstStudent As List(Of String)
        lstStudent = New List(Of String)
        Dim lstStudent1 As New List(Of String)
        For i As Integer = 0 To 6
            lstStudent.Add("学生" & i)
        Next
        For Each p As String In lstStudent
            Console.Write(p & " ")
        Next
        Console.WriteLine()

        ' IF
        Dim age As Integer = 18
        If IsNumeric(age) Then
            Console.WriteLine("是数字")
        Else
            Console.WriteLine("非数字")
        End If

        If IsNumeric(age) Then
            Console.WriteLine("是数字")
            If age > 18 Then
                Console.WriteLine("大于18")
            Else
                Console.WriteLine("不大于18")
            End If
        Else
            Console.WriteLine("非数字")
        End If

        ' IIf 三元运算符
        Dim iifString As String

        iifString = IIf(age = 18, "是18", "非18")
        Console.WriteLine(iifString)

        ' Select 选择语句
        iifString = "c"
        Select Case iifString
            Case "a"
                Console.WriteLine("a")
            Case "b"
                Console.WriteLine("b")
            Case Else
                Console.WriteLine("其他")
        End Select
    End Sub
End Module
