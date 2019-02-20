// <snippetworkingwithtimezones>


using System;
using System.ServiceModel;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// This sample shows how to use various SDK messages with time zones.
    /// </summary>
    /// <remarks>
    /// At run-time, you will be given the option to delete all the
    /// database records created by this program.
    /// </remarks>
    public class WorkingWithTimeZones
    {
        #region Class Level Members
        private OrganizationServiceProxy _serviceProxy;
        private string _timeZoneName;
        private Guid? _timeZoneId;
        private int? _localeId;
        private int? _timeZoneCode;
        #endregion

        #region How To Sample Code

        /// <summary>
        /// This method shows how to retrieve the user's time zone, retrieve time zones
        /// on the system and convert time between UTC and local time for a user.
        /// </summary>
        /// <param name="serverConfig">Contains server connection information.</param>
        /// <param name="promptforDelete">When True, the user will be prompted to delete
        /// all created entities.</param>
        public void Run(ServerConnection.Configuration serverConfig,
            bool promptforDelete)
        {
            using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
            {
                // This statement is required to enable early-bound type support.
                _serviceProxy.EnableProxyTypes();

                _timeZoneId = new Guid("42B2880D-BED5-4AA3-BD69-418052D38B7E");
                _timeZoneName = "Central Standard Time";
                RetrieveCurrentUsersSettings();
                     
                RetrieveAllTimeZonesForLocale();
                GetTimeZoneCodeByLocaleAndName();
                RetrieveTimeZoneById();
                RetrieveTimeZonesLessThan50();
                RetrieveLocalTimeFromUTCTime(new DateTime(1981, 6, 6, 9, 5, 0));
                RetrieveUTCTimeFromLocalTime(new DateTime(2012, 1, 1, 0, 0, 0));
            }
        }

        /// <summary>
        /// Retrieves the current users timezone code and locale id
        /// </summary>
        private void RetrieveCurrentUsersSettings()
        {
            var currentUserSettings = _serviceProxy.RetrieveMultiple(
                new QueryExpression(UserSettings.EntityLogicalName)
                {
                    ColumnSet = new ColumnSet("localeid", "timezonecode"),
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("systemuserid", ConditionOperator.EqualUserId)
                        }
                    }
                }).Entities[0].ToEntity<UserSettings>();

            _localeId = currentUserSettings.LocaleId;
            _timeZoneCode = currentUserSettings.TimeZoneCode;
        }

        /// <summary>
        /// Uses the current locale id to retrieve all the timezones 
        /// </summary>
        private void RetrieveAllTimeZonesForLocale()
        {
            if (!_localeId.HasValue)
                return;
            
            Console.WriteLine(String.Concat("Retrieving time zones for locale id: ",
                _localeId.Value));

            var response = (GetAllTimeZonesWithDisplayNameResponse) _serviceProxy.Execute(
                new GetAllTimeZonesWithDisplayNameRequest
                {
                    LocaleId = _localeId.Value,
                });

            for (int i = 0; i < response.EntityCollection.Entities.Count; i++)
            {
                var timeZoneDefinition = response.EntityCollection
                    .Entities[i].ToEntity<TimeZoneDefinition>();

                Console.WriteLine(String.Concat(timeZoneDefinition.UserInterfaceName,
                    " found for ", _localeId.Value));
            }
        }

        /// <summary>
        /// Retrieves a timezone by the name and the locale ID
        /// </summary>
        private void GetTimeZoneCodeByLocaleAndName()
        {
            if (string.IsNullOrWhiteSpace(_timeZoneName) || !_localeId.HasValue)
                return;

            var request = new GetTimeZoneCodeByLocalizedNameRequest
            {
                LocaleId = _localeId.Value,
                LocalizedStandardName = _timeZoneName
            };

            var response = (GetTimeZoneCodeByLocalizedNameResponse)
                _serviceProxy.Execute(request);

            Console.WriteLine(String.Concat("Time zone code: ", response.TimeZoneCode,
                " retrieved for locale id: ", _localeId.Value, ", and time zone name: ",
                _timeZoneName));
        }

        /// <summary>
        /// Retieve time zone by id
        /// </summary>
        private void RetrieveTimeZoneById()
        {
            if (!_timeZoneId.HasValue)
                return;

            // In addition to the RetrieveRequest message, 
            // you may use the IOrganizationService.Retrieve method
            var request = new RetrieveRequest
            {
                Target = new EntityReference(
                    TimeZoneDefinition.EntityLogicalName, _timeZoneId.Value),
                ColumnSet = new ColumnSet("standardname")
            };

            var response = (RetrieveResponse)_serviceProxy.Execute(request);

            Console.WriteLine(String.Concat("Retrieve request on time zone ",
                _timeZoneId.Value, ".  Name: ", response.Entity.
                ToEntity<TimeZoneDefinition>().StandardName));
        }

        /// <summary>
        /// Retrieve time zones less than 50.
        /// </summary>
        private void RetrieveTimeZonesLessThan50()
        {
            // In addition to the RetrieveMultipleRequest message,
            // you may use the IOrganizationService.RetrieveMultiple method.
            var request = new RetrieveMultipleRequest
            {
                Query = new QueryExpression(TimeZoneDefinition.EntityLogicalName)
                {
                    ColumnSet = new ColumnSet("timezonecode", "standardname"),
                    Criteria = new FilterExpression
                    {
                        Conditions =
                        {
                            new ConditionExpression("timezonecode", 
                                ConditionOperator.LessThan, 50)
                        }
                    }
                }
            };

            Console.WriteLine("Retrieving all timezones with a timezonecode less than 50");
            var response = (RetrieveMultipleResponse)_serviceProxy.Execute(request);

            foreach (var item in response.EntityCollection.Entities)
            {
                var timeZone = item.ToEntity<TimeZoneDefinition>();

                Console.WriteLine(String.Concat("Time zone name: ",
                    timeZone.StandardName, ", time zone code: ",
                    !timeZone.TimeZoneCode.HasValue ? "null" :
                    timeZone.TimeZoneCode.Value.ToString()));
            }

        }

        /// <summary>
        /// Retrieve the local time from the UTC time.
        /// </summary>
        /// <param name="utcTime"></param>
        private void RetrieveLocalTimeFromUTCTime(DateTime utcTime)
        {
            if (!_timeZoneCode.HasValue)
                return;                

            var request = new LocalTimeFromUtcTimeRequest
            {
                TimeZoneCode = _timeZoneCode.Value,
                UtcTime = utcTime.ToUniversalTime()
            };

            var response = (LocalTimeFromUtcTimeResponse)_serviceProxy.Execute(request);

            Console.WriteLine(String.Concat("Calling LocalTimeFromUtcTimeRequest.  UTC time: ",
                utcTime.ToString("MM/dd/yyyy HH:mm:ss"), ". Local time: ",
                response.LocalTime.ToString("MM/dd/yyyy HH:mm:ss")));
        }

        /// <summary>
        /// Retrieves the utc time from the local time
        /// </summary>
        /// <param name="localTime"></param>
        private void RetrieveUTCTimeFromLocalTime(DateTime localTime)
        {
            if (!_timeZoneCode.HasValue)
                return;   

            var request = new UtcTimeFromLocalTimeRequest
            {
                TimeZoneCode = _timeZoneCode.Value,
                LocalTime = localTime
            };

            var response = (UtcTimeFromLocalTimeResponse)_serviceProxy.Execute(request);

            Console.WriteLine(String.Concat("Calling UtcTimeFromLocalTimeRequest.  Local time: ",
                localTime.ToString("MM/dd/yyyy HH:mm:ss"), ". UTC time: ",
                response.UtcTime.ToString("MM/dd/yyyy HH:mm:ss")));
        }
        #endregion

        #region Main method
        /// <summary>
        /// Standard Main() method used by most SDK samples.
        /// </summary>
        /// <param name="args"></param>
        static public void Main(string[] args)
        {
            try
            {
                // Obtain the target organization's Web address and client logon 
                // credentials from the user.
                ServerConnection serverConnect = new ServerConnection();
                ServerConnection.Configuration config = serverConnect.GetServerConfiguration();

                var app = new WorkingWithTimeZones();
                app.Run(config, true);
            }
            catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
                Console.WriteLine("Message: {0}", ex.Detail.Message);
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
            }
            catch (System.TimeoutException ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine("Message: {0}", ex.Message);
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
                Console.WriteLine("Inner Fault: {0}",
                    null == ex.InnerException.Message ? "No Inner Fault" : ex.InnerException.Message);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("The application terminated with an error.");
                Console.WriteLine(ex.Message);

                // Display the details of the inner exception.
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);

                    FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe = ex.InnerException
                        as FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>;
                    if (fe != null)
                    {
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp);
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode);
                        Console.WriteLine("Message: {0}", fe.Detail.Message);
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText);
                        Console.WriteLine("Inner Fault: {0}",
                            null == fe.Detail.InnerFault ? "No Inner Fault" : "Has Inner Fault");
                    }
                }
            }
            // Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            // SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            finally
            {
                Console.WriteLine("Press <Enter> to exit.");
                Console.ReadLine();
            }
        }
        #endregion
    }
}

// </snippetworkingwithtimezones>