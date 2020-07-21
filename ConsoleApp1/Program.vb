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
        '����ע��
        REM ����ע��
        '��������
        Dim strName, strGender As String
        strName = "pwx"
        strGender = "��"
        Console.WriteLine(strName) : Console.WriteLine(strGender)
        ' ��������
        ' Byte Short/Int16 Integer/Int32 Long/Int64
        ' Single Double
        ' Decimal

        ' �ַ�����
        ' Char String
        Dim str, str1 As String
        str = strName & strGender
        str1 = strName + strGender
        Console.WriteLine(str)
        Console.WriteLine(str1)
        Console.WriteLine("���ȣ�" & str.Length)
        str = strName.ToUpper()
        Console.WriteLine(str)
        Console.WriteLine(strName.ToUpper)
        str = "This is a test"
        str1 = str.Substring(5, 4) '����5��ʼ����ȡ4��
        Console.WriteLine(str1)
        Dim strBoolean As String = "True"
        Console.WriteLine(CType(strBoolean, Boolean))

        ' ʱ��
        Dim date1, date2 As Date
        date1 = Now()
        Console.WriteLine(date1)
        date2 = New DateTime(2018, 1, 1, 23, 59, 59)
        Console.WriteLine(date1)
        Console.WriteLine(date1.ToString("yyyy/MM/dd"))
        Console.WriteLine(String.Format(date1, "yyyy/MM/dd HH/mm/ss"))
        Dim tspan As TimeSpan
        tspan = date1.Subtract(date2)
        Console.WriteLine("������" & tspan.Days)
        Console.WriteLine("�������" & tspan.TotalDays)
        Console.WriteLine("Сʱ��" & tspan.Hours)
        Console.WriteLine("���Сʱ" & tspan.TotalHours)
        Dim monthDiff As Integer
        monthDiff = DateDiff(DateInterval.Month, date2, date1)
        Console.WriteLine("�������" & monthDiff)

        ' ����
        Console.WriteLine(7 / 2)
        ' ȡ��
        Console.WriteLine(7 \ 2)
        ' ȡ��
        Console.WriteLine(7 Mod 2)

        Dim studentInfo As New Student("С��", 1999, Gender.female)
        Console.WriteLine(studentInfo.name & "," & studentInfo.age & "," & studentInfo.sex)
        ' ����
        Dim people(10) As String
        ReDim people(15) '���·�������Ĵ�С ���������
        For i As Integer = 0 To 15
            people(i) = "people:" & i.ToString
            Console.WriteLine(people(i))
        Next

        ReDim Preserve people(17) '���·��� �������
        For Each p In people
            Console.WriteLine("Redim Preserve:" & p)
        Next
        ' ��ά����
        Dim students(2, 5) As String
        For i As Integer = 0 To 2
            For j As Integer = 0 To 5
                students(i, j) = (i + 1) & "��" & (j + 1) & "��"
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
            lstStudent.Add("ѧ��" & i)
        Next
        For Each p As String In lstStudent
            Console.Write(p & " ")
        Next
        Console.WriteLine()

        ' IF
        Dim age As Integer = 18
        If IsNumeric(age) Then
            Console.WriteLine("������")
        Else
            Console.WriteLine("������")
        End If

        If IsNumeric(age) Then
            Console.WriteLine("������")
            If age > 18 Then
                Console.WriteLine("����18")
            Else
                Console.WriteLine("������18")
            End If
        Else
            Console.WriteLine("������")
        End If

        ' IIf ��Ԫ�����
        Dim iifString As String

        iifString = IIf(age = 18, "��18", "��18")
        Console.WriteLine(iifString)

        ' Select ѡ�����
        iifString = "c"
        Select Case iifString
            Case "a"
                Console.WriteLine("a")
            Case "b"
                Console.WriteLine("b")
            Case Else
                Console.WriteLine("����")
        End Select
    End Sub
End Module
