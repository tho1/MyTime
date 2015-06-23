Public Class Airplane

    Private _lastId As Integer
    Public _id As Integer
    Public _fuelKg As Integer
    Public _model As String
    Dim passengerArray() As Passenger


    Public Sub SetPassenger(ByVal pass As Passenger())
        passengerArray = pass
    End Sub


    Public Function getPassenger()
        Return passengerArray
    End Function


    Public Sub New(ByVal Value As Integer)
        _id = Value
    End Sub

    Public Sub New(ByVal Value As Integer, ByVal model As String, ByVal fuel As String)
        _id = Value
        _model = model
        _fuelKg = fuel
    End Sub

    Public Property id()
        Get
            Return _id
        End Get
        Set(ByVal value)
            _id = value
        End Set
    End Property

    Public Property model()
        Get
            Return _model
        End Get
        Set(ByVal value)
            _model = value
        End Set
    End Property

    Public Property fuel()
        Get
            Return _fuelKg
        End Get
        Set(ByVal value)
            _fuelKg = value
        End Set
    End Property

End Class
