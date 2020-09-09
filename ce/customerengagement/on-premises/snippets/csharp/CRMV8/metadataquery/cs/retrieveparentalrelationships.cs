// <snippetretrieveparentalrelationships>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.IO;
using System.Collections.Generic;
// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;


namespace Microsoft.Crm.Sdk.Samples
{
 public class RetrieveParentalRelationships
 {
  #region Class Level Members

  private OrganizationServiceProxy _serviceProxy;
  private IOrganizationService _service;
  private Guid _userId;
  private int _languageCode;



  #endregion Class Level Members


  /// <summary>
  /// This method connects to the Organization _service. 
  /// </summary>
  /// <param name="serverConfig">Contains server connection information.</param>

  public void Run(ServerConnection.Configuration serverConfig)
  {
   try
   {

    // Connect to the Organization _service. 
    // The using statement assures that the _service proxy will be properly disposed.
       using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri, serverConfig.Credentials, serverConfig.DeviceCredentials))
    {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     _service = (IOrganizationService)_serviceProxy;

     _userId = ((WhoAmIResponse)_service.Execute(new WhoAmIRequest())).UserId;
     _languageCode = RetrieveUserUILanguageCode(_userId);



     //A filter expression to limit entities returned to non-intersect entities
     MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
     EntityFilter.Conditions.Add(new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false));


     //A properties expression to limit the properties to be included with entities
     MetadataPropertiesExpression EntityProperties = new MetadataPropertiesExpression()
     {
      AllProperties = false
     };
     EntityProperties.PropertyNames.AddRange(new string[] { "OneToManyRelationships", "LogicalName", "DisplayName" });




     //A filter expression to only return system entity relationships
     MetadataFilterExpression relationshipFilter = new MetadataFilterExpression(LogicalOperator.And);
     relationshipFilter.Conditions.Add(new MetadataConditionExpression("IsCustomRelationship", MetadataConditionOperator.Equals, false));

     //A Properties expression to limit the properties to be included with relationships
     MetadataPropertiesExpression relationshipProperties = new MetadataPropertiesExpression() { AllProperties = false };
     relationshipProperties.PropertyNames.Add("CascadeConfiguration");
     relationshipProperties.PropertyNames.Add("SchemaName");
     relationshipProperties.PropertyNames.Add("IsCustomizable");


     //A label query expression to limit the labels returned to only those for the user's preferred language
     LabelQueryExpression labelQuery = new LabelQueryExpression();
     labelQuery.FilterLanguages.Add(_languageCode);


     //An entity query expression to combine the filter expressions and property expressions for the query.
     EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
     {

      Criteria = EntityFilter,
      Properties = EntityProperties,
      RelationshipQuery = new RelationshipQueryExpression() { Criteria = relationshipFilter, Properties = relationshipProperties },
      LabelQuery = labelQuery

     };

     //Define the request
     RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest() { Query = entityQueryExpression };

     //Retrieve the data
     RetrieveMetadataChangesResponse response = (RetrieveMetadataChangesResponse)_service.Execute(request);


     //Process the data
     foreach (EntityMetadata entity in response.EntityMetadata)
     {
      if (entity.OneToManyRelationships != null)
      {
       foreach (OneToManyRelationshipMetadata relationship in entity.OneToManyRelationships)
       {
        var cascadeConfig = relationship.CascadeConfiguration;
        //When all of the CascadeConfiguration properties use the Cascade behavior the relationship is considered parental
        if (cascadeConfig.Assign == CascadeType.Cascade &&
         cascadeConfig.Delete == CascadeType.Cascade &&
         cascadeConfig.Merge == CascadeType.Cascade &&
         cascadeConfig.Reparent == CascadeType.Cascade &&
         cascadeConfig.Share == CascadeType.Cascade &&
         cascadeConfig.Unshare == CascadeType.Cascade)
        {
         //Only show results for relationships that can be customized
         if (relationship.IsCustomizable.Value)
         {
          //Write the entity name and the name of the relationship.
          Console.WriteLine(entity.DisplayName.UserLocalizedLabel.Label + "," + relationship.SchemaName);
         }
        }
       }
      }
     }
    }
   }

   // Catch any _service fault exceptions that Microsoft Dynamics CRM throws.
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
   {
    // You can handle an exception here or pass it back to the calling method.
    throw;
   }
  }


  protected int RetrieveUserUILanguageCode(Guid userId)
  {
   QueryExpression userSettingsQuery = new QueryExpression("usersettings");
   userSettingsQuery.ColumnSet.AddColumns("uilanguageid", "systemuserid");
   userSettingsQuery.Criteria.AddCondition("systemuserid", ConditionOperator.Equal, userId);
   EntityCollection userSettings = _service.RetrieveMultiple(userSettingsQuery);
   if (userSettings.Entities.Count > 0)
   {
    return (int)userSettings.Entities[0]["uilanguageid"];
   }
   return 0;
  }




  #region Main method

  /// <summary>
  /// Based on the Main() method used by most SDK samples.
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

    RetrieveParentalRelationships app = new RetrieveParentalRelationships();
    app.Run(config);
   }

   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
   {
    Console.WriteLine("The application terminated with an error.");
    Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
    Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
    Console.WriteLine("Message: {0}", ex.Detail.Message);
    Console.WriteLine("Trace: {0}", ex.Detail.TraceText);
    Console.WriteLine("Inner Fault: {0}",
        null == ex.Detail.InnerFault ? "Has Inner Fault" : "No Inner Fault");
   }
   catch (System.TimeoutException ex)
   {
    Console.WriteLine("The application terminated with an error.");
    Console.WriteLine("Message: {0}", ex.Message);
    Console.WriteLine("Stack Trace: {0}", ex.StackTrace);
    Console.WriteLine("Inner Fault: {0}",
        null == ex.InnerException.Message ? "Has Inner Fault" : "No Inner Fault");
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
      Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
      Console.WriteLine("Inner Fault: {0}",
          null == fe.Detail.InnerFault ? "Has Inner Fault" : "No Inner Fault");
     }
    }
   }

    //Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
   //SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

   finally
   {
    Console.WriteLine("Press <Enter> to exit.");
    Console.ReadLine();
   }
  }
  #endregion Main method

 }




}

// </snippetretrieveparentalrelationships>