Public Class $safeitemname$
    Implements IEnumerable(Of Object())

    Public Iterator Function GetEnumerator() As IEnumerator(Of Object()) Implements IEnumerable(Of Object()).GetEnumerator

        Yield New Object() {New Object()}

    End Function

    Private Function GetUntypedEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

End Class