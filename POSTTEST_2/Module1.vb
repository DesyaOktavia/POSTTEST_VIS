Module ModulBuku
	Public dataBuku(100, 3) As String
	Public jumlahBuku As Integer = 0

	Public Sub TambahBuku(ByVal kode As String, ByVal judul As String,
						  ByVal pengarang As String, ByVal tahun As String)
		dataBuku(jumlahBuku, 0) = kode
		dataBuku(jumlahBuku, 1) = judul
		dataBuku(jumlahBuku, 2) = pengarang
		dataBuku(jumlahBuku, 3) = tahun
		jumlahBuku = jumlahBuku + 1
	End Sub

	Public Sub HapusBuku(ByVal kodeHapus As String, ByVal judulHapus As String, ByRef berhasil As Boolean)
		Dim i As Integer
		Dim indexKetemu As Integer = -1
		For i = 0 To jumlahBuku - 1
			If dataBuku(i, 0) = kodeHapus And dataBuku(i, 1) = judulHapus Then
				indexKetemu = i
				Exit For
			End If
		Next i
		If indexKetemu >= 0 Then
			For i = indexKetemu To jumlahBuku - 2
				dataBuku(i, 0) = dataBuku(i + 1, 0)
				dataBuku(i, 1) = dataBuku(i + 1, 1)
				dataBuku(i, 2) = dataBuku(i + 1, 2)
				dataBuku(i, 3) = dataBuku(i + 1, 3)
			Next i
			dataBuku(jumlahBuku - 1, 0) = ""
			dataBuku(jumlahBuku - 1, 1) = ""
			dataBuku(jumlahBuku - 1, 2) = ""
			dataBuku(jumlahBuku - 1, 3) = ""

			jumlahBuku = jumlahBuku - 1
			berhasil = True
		Else
			berhasil = False
		End If
	End Sub

	Public Function CekDuplikat(ByVal kodeBaru As String, ByVal judulBaru As String) As Boolean
		Dim i As Integer
		For i = 0 To jumlahBuku - 1
			If dataBuku(i, 0) = kodeBaru Or dataBuku(i, 1) = judulBaru Then
				Return True
			End If
		Next i
		Return False
	End Function

	Public Function FormatTampilBuku(ByVal index As Integer) As String
		Dim hasil As String
		hasil = "[" & dataBuku(index, 0) & "] " &
				dataBuku(index, 1) & " - " &
				dataBuku(index, 2) & " (" &
				dataBuku(index, 3) & ")"
		Return hasil
	End Function
End Module