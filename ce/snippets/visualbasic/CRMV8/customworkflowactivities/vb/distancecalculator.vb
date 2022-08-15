' <snippetdistancecalculator>


Imports System.Activities
Imports System.Net
Imports System.Runtime.Serialization.Json

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk

' These namespaces are found in the Microsoft.Xrm.Sdk.Workflow.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk.Workflow

' These namespace is used to deserialize to JSON object
Imports Microsoft.Crm.Sdk.Samples.BingMapsRestV1

Namespace Microsoft.Crm.Sdk.Samples

	''' <summary>
	''' Calculates the shortest distance between two points based on their zipcodes,
	''' and returns the value.
	''' Input arguments:
	'''   "Starting Zip Code". Type: String. Is the start point.
	'''   "Ending Zip Code". Type: String. Is the end point.
	''' Output argument:
	'''   "Total Distance". Type: Double. Is the total distance measured in km.
	''' </summary>
	Public NotInheritable Partial Class DistanceCalculator
		Inherits CodeActivity
		''' <summary>
		''' Calculates the shortest distance between two points based on their zipcodes,
		''' and returns the value.
		''' </summary>
		Protected Overrides Sub Execute(ByVal executionContext As CodeActivityContext)
			Dim context As IWorkflowContext = executionContext.GetExtension(Of IWorkflowContext)()
			Dim serviceFactory As IOrganizationServiceFactory = executionContext.GetExtension(Of IOrganizationServiceFactory)()
			Dim service As IOrganizationService = serviceFactory.CreateOrganizationService(context.UserId)

			' Calculate the distance between those two points
			' based on the Zip Codes
			Dim distance As Double = CalculateDistance(Me.startingZipCode.Get(executionContext), Me.endingZipCode.Get(executionContext))

			' Set the result in the output parameter
			Me.totalDistance.Set(executionContext, distance)
		End Sub

		''' <summary>
		''' Calculates the shortest distance between two points based on their zipcodes,
		''' and returns the value.
		''' </summary> 
		Private Function CalculateDistance(ByVal startPoint As String, ByVal endPoint As String) As Double
			Dim distance As Double = 0.0

			' Required start and end waypoint parameters (location string 
			' or a pair of latitude and longitude coordinates). 
			Dim fromAddress As String = startPoint
			Dim toAddress As String = endPoint

			' Optional route calculation parameters: 
			' Optimize route for the shortest distance. 
			Dim optimize As String = "distance"

			' Driving travel mode: driving/walking/transit
			Dim travelMode As String = "driving"

			' Measure distance: km/mi
			Dim distanceUnit As String = "km"

			' User needs to put here his/her Bing Maps Key 
			Dim BingMapsKey As String = "Au9tmAwIDZ2XAQVedm85L51EujHtSfgvdFBLpLXBvH-p94kNrokavf00POMu74Xz"

			' Create a REST request for the route's details. 
			Dim requestUrl As String = "https://dev.virtualearth.net/REST/v1/Routes" &amp; "?output=json" &amp; "&amp;key=" &amp; BingMapsKey &amp; "&amp;wp.0=" &amp; fromAddress &amp; "&amp;wp.1=" &amp; toAddress &amp; "&amp;optimize=" &amp; optimize &amp; "&amp;travelMode=" &amp; travelMode &amp; "&amp;distanceUnit=" &amp; distanceUnit

			' Send the request and parse the response. 
			Dim jsonResponse As BingMapsRestV1.Response = GetJsonResponse(requestUrl)

			' Get the shortest distance
			distance = ( _
			    From r As Route In jsonResponse.ResourceSets(0).Resources _
			    Order By r.TravelDistance Ascending _
			    Select r.TravelDistance).First()

			Return distance
		End Function

		''' <summary>
		''' Send the request to the Bing Maps REST API 
		''' and deserialize the JSON response. 
		''' </summary> 
		Private Function GetJsonResponse(ByVal requestUrl As String) As Response
			Dim request As HttpWebRequest = TryCast(WebRequest.Create(requestUrl), HttpWebRequest)
			Using response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
				If response.StatusCode <> HttpStatusCode.OK Then
					Throw New Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription))
				End If
				Dim jsonSerializer As New DataContractJsonSerializer(GetType(BingMapsRestV1.Response))
				Dim objResponse As Object = jsonSerializer.ReadObject(response.GetResponseStream())
				Dim jsonResponse As BingMapsRestV1.Response = TryCast(objResponse, BingMapsRestV1.Response)
				Return jsonResponse
			End Using
		End Function

		' Define Input/Output Arguments
		<RequiredArgument, Input("Starting Zip Code")> _
		Public Property startingZipCode() As InArgument(Of String)

		<RequiredArgument, Input("Ending Zip Code")> _
		Public Property endingZipCode() As InArgument(Of String)

		<Output("Total Distance")> _
		Public Property totalDistance() As OutArgument(Of Double)
	End Class
End Namespace

' </snippetdistancecalculator>