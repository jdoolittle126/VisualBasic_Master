Imports Microsoft.VisualBasic
Imports System.Xml

Dim mapSizeX As Integer
Dim mapSizeY As Integer

Public Class Class1
    Dim mapWriter As New XmlTextWriter("mapnamehere.xml", System.Text.Encoding.UTF8)


    Public Sub writeMap(map As list(Of tile), entities As list(Of entity)) 'Change to tile
        mapWriter.WriteStartDocument(True)
        mapWriter.Formatting = Formatting.Indented
        mapWriter.Indentation = 2
        mapWriter.WriteStartElement("Tiles")
        Dim counter As Integer = 0
        For x = 0 To mapSizeX
            For y = 0 To mapSizeY
                counter += 1
                createNodeTile(map(x, y), counter, mapWriter)
            Next
        Next
        mapWriter.WriteEndElement()
        counter = 0
        mapWriter.WriteStartElement("Entities")
        For Each entity In entities
            counter += 1
            createNodeEntity(entity, counter, mapWriter)
        Next


    End Sub

    Private Sub createNodeTile(ByVal thisTile As Object, ByVal counter As Integer, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Tile " + counter.ToString)

        writer.WriteStartElement("Some Tile Property")
        writer.WriteString(thisTile.someProperty.ToString)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Sub

    Private Sub createNodeEntity(ByVal thisEntity As Object, ByVal counter As Integer, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Entity " + counter.ToString)

        writer.WriteStartElement("Some Tile Property")
        writer.WriteString(thisTile.someProperty.ToString)
        writer.WriteEndElement()

        writer.WriteEndElement()
    End Sub

End Class
