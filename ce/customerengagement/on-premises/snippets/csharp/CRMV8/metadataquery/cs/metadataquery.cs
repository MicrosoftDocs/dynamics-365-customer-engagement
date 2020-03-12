// <snippetmetadataquery>


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
 public class MetadataQuerySample
 {
  #region Class Level Members

  private OrganizationServiceProxy _serviceProxy;
  private IOrganizationService _service;
  private List<OptionSetOption> _optionLabelList = new List<OptionSetOption>();
  private String _customEntitySchemaName = "sample_SampleEntityForMetadataQuery";
  private String _customAttributeSchemaName = "sample_ExampleOptionSet";
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




     // An array SchemaName values for non-intersect, user-owned entities that should not be returned.
     String[] excludedEntities = {
"WorkflowLog",
"Template",
"CustomerOpportunityRole",
"Import",
"UserQueryVisualization",
"UserEntityInstanceData",
"ImportLog",
"RecurrenceRule",
"QuoteClose",
"UserForm",
"SharePointDocumentLocation",
"Queue",
"DuplicateRule",
"OpportunityClose",
"Workflow",
"RecurringAppointmentMaster",
"CustomerRelationship",
"Annotation",
"SharePointSite",
"ImportData",
"ImportFile",
"OrderClose",
"Contract",
"BulkOperation",
"CampaignResponse",
"Connection",
"Report",
"CampaignActivity",
"UserEntityUISettings",
"IncidentResolution",
"GoalRollupQuery",
"MailMergeTemplate",
"Campaign",
"PostFollow",
"ImportMap",
"Goal",
"AsyncOperation",
"ProcessSession",
"UserQuery",
"ActivityPointer",
"List",
"ServiceAppointment"};

     //A filter expression to limit entities returned to non-intersect, user-owned entities not found in the list of excluded entities.
     MetadataFilterExpression EntityFilter = new MetadataFilterExpression(LogicalOperator.And);
     EntityFilter.Conditions.Add(new MetadataConditionExpression("IsIntersect", MetadataConditionOperator.Equals, false));
     EntityFilter.Conditions.Add(new MetadataConditionExpression("OwnershipType", MetadataConditionOperator.Equals, OwnershipTypes.UserOwned));
     EntityFilter.Conditions.Add(new MetadataConditionExpression("SchemaName", MetadataConditionOperator.NotIn, excludedEntities));
     MetadataConditionExpression isVisibileInMobileTrue = new MetadataConditionExpression("IsVisibleInMobile", MetadataConditionOperator.Equals, true);
     EntityFilter.Conditions.Add(isVisibileInMobileTrue);

     

     //A properties expression to limit the properties to be included with entities
     MetadataPropertiesExpression EntityProperties = new MetadataPropertiesExpression()
     {
      AllProperties = false
     };
     EntityProperties.PropertyNames.AddRange(new string[] { "Attributes" });
     
     //A condition expresson to return optionset attributes
     MetadataConditionExpression[] optionsetAttributeTypes = new MetadataConditionExpression[] { 
     new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Picklist),
     new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.State),
     new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status),
     new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Boolean)
     };

     //A filter expression to apply the optionsetAttributeTypes condition expression
     MetadataFilterExpression AttributeFilter = new MetadataFilterExpression(LogicalOperator.Or);
     AttributeFilter.Conditions.AddRange(optionsetAttributeTypes);

     //A Properties expression to limit the properties to be included with attributes
     MetadataPropertiesExpression AttributeProperties = new MetadataPropertiesExpression() { AllProperties = false };
     AttributeProperties.PropertyNames.Add("OptionSet");
     AttributeProperties.PropertyNames.Add("AttributeType");



     //A label query expression to limit the labels returned to only those for the user's preferred language
     LabelQueryExpression labelQuery = new LabelQueryExpression();
     labelQuery.FilterLanguages.Add(_languageCode);


     //An entity query expression to combine the filter expressions and property expressions for the query.
     EntityQueryExpression entityQueryExpression = new EntityQueryExpression()
     {

      Criteria = EntityFilter,
      Properties = EntityProperties,
      AttributeQuery = new AttributeQueryExpression()
      {
       Criteria = AttributeFilter,
       Properties = AttributeProperties
      },
      LabelQuery = labelQuery

     };
     
     //Retrieve the metadata for the query without a ClientVersionStamp
     RetrieveMetadataChangesResponse initialRequest = getMetadataChanges(entityQueryExpression, null, DeletedMetadataFilters.OptionSet);

     //Add option labels to the cache and display the changes
     addOptionLabelsToCache(initialRequest.EntityMetadata, false);
     String ClientVersionStamp = initialRequest.ServerVersionStamp;
     Console.WriteLine("{0} option labels for {1} entities added to the cache.", 
      _optionLabelList.Count, 
      initialRequest.EntityMetadata.Count);
     Console.WriteLine("");
     Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp);
     Console.WriteLine("");


     //Add new custom entity with optionset
     Console.WriteLine("Adding a custom entity named {0} with a custom optionset attribute named : {1}", 
      _customEntitySchemaName, _customAttributeSchemaName);
     Console.WriteLine("");
     addCustomEntityWithOptionSet();
     //Publishing isn't necessary when adding a custom entity

     //Add new option labels to the cache and display the results
     ClientVersionStamp = updateOptionLabelList(entityQueryExpression, ClientVersionStamp);

     Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp);
     Console.WriteLine("");

     //Add a new option to the custom optionset in the custom entity and publish the custom entity
     Console.WriteLine("Adding an additional option to the {0} attribute options.", 
      _customAttributeSchemaName);
     Console.WriteLine("");
     addOptionToCustomEntityOptionSet();
     //It is necessary to publish updates to metadata. Create and Delete operations are published automatically.
     publishUpdatedEntity();



     //Add the new option label to the cache and display the results
     ClientVersionStamp = updateOptionLabelList(entityQueryExpression, ClientVersionStamp);

     Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp);
     Console.WriteLine("");

     Console.WriteLine("");
     Console.WriteLine("Current Options: {0}", _optionLabelList.Count.ToString());
     Console.WriteLine("");

     //Delete the custom entity
     Console.WriteLine("");
     Console.WriteLine("Deleting the {0} custom entity", 
      _customEntitySchemaName);
     Console.WriteLine("");
     deleteCustomEntityWithOptionSet();
     //Publishing isn't necessary when deleting a custom entity     


     //Retrieve metadata changes to remove option labels from deleted attributes and display the results
     ClientVersionStamp = updateOptionLabelList(entityQueryExpression, ClientVersionStamp);

     Console.WriteLine("ClientVersionStamp: {0}", ClientVersionStamp);
     Console.WriteLine("");

    }

   }

   // Catch any _service fault exceptions that Microsoft Dynamics CRM throws.
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
   {
    // You can handle an exception here or pass it back to the calling method.
    throw;
   }
  }

  protected RetrieveMetadataChangesResponse getMetadataChanges(
   EntityQueryExpression entityQueryExpression,
   String clientVersionStamp,
   DeletedMetadataFilters deletedMetadataFilter)
  {
   RetrieveMetadataChangesRequest retrieveMetadataChangesRequest = new RetrieveMetadataChangesRequest()
   {
    Query = entityQueryExpression,
    ClientVersionStamp = clientVersionStamp,
    DeletedMetadataFilters = deletedMetadataFilter
   };

   return (RetrieveMetadataChangesResponse)_service.Execute(retrieveMetadataChangesRequest);

  }

  protected String updateOptionLabelList(EntityQueryExpression entityQueryExpression, String clientVersionStamp)
  {
   //Retrieve metadata changes and add them to the cache
   RetrieveMetadataChangesResponse updateResponse;
   try
   {
    updateResponse = getMetadataChanges(entityQueryExpression, clientVersionStamp, DeletedMetadataFilters.OptionSet);
    addOptionLabelsToCache(updateResponse.EntityMetadata, true);
    removeOptionLabelsFromCache(updateResponse.DeletedMetadata, true);

   }
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
   {
    // Check for ErrorCodes.ExpiredVersionStamp (0x80044352)
    // Will occur when the timestamp exceeds the Organization.ExpireSubscriptionsInDays value, which is 90 by default.
    if (ex.Detail.ErrorCode == unchecked((int)0x80044352))
    {
     //reinitialize cache
     _optionLabelList.Clear();

     updateResponse = getMetadataChanges(entityQueryExpression, null, DeletedMetadataFilters.OptionSet);
     //Add them to the cache and display the changes
     addOptionLabelsToCache(updateResponse.EntityMetadata, true);

    }
    else
    {
     throw ex;
    }

   }
   return updateResponse.ServerVersionStamp;
  }
  protected void addOptionLabelsToCache(EntityMetadataCollection entityMetadataCollection, Boolean showChanges)
  {

   List<OptionSetOption> changes = new List<OptionSetOption>();

   foreach (EntityMetadata em in entityMetadataCollection)
   {
    foreach (AttributeMetadata am in em.Attributes)
    {
     switch (am.AttributeType)
     {
      case AttributeTypeCode.Boolean:
       BooleanAttributeMetadata booleanAttribute = (BooleanAttributeMetadata)am;
       //Labels will not be included if they aren't new
       if (booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel != null)
       {
        changes.Add(new OptionSetOption(
        (Guid)booleanAttribute.OptionSet.MetadataId,
        0, 
        booleanAttribute.OptionSet.FalseOption.Label.UserLocalizedLabel.Label)
        );
       }
       //Labels will not be included if they aren't new
       if (booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel != null)
       {
        changes.Add(new OptionSetOption(
        (Guid)booleanAttribute.OptionSet.MetadataId,
        1, 
        booleanAttribute.OptionSet.TrueOption.Label.UserLocalizedLabel.Label));
       }
       break;
      default:
       EnumAttributeMetadata optionsetAttribute = (EnumAttributeMetadata)am;
       foreach (OptionMetadata option in optionsetAttribute.OptionSet.Options)
       {
        //Labels will not be included if they aren't new
        if (option.Label.UserLocalizedLabel != null)
        {
         changes.Add(new OptionSetOption(
          (Guid)optionsetAttribute.OptionSet.MetadataId,
         (int)option.Value, 
         option.Label.UserLocalizedLabel.Label));
        }        
       }
       break;
     }
    }
   }

   _optionLabelList.AddRange(changes);

   if (showChanges)
   {

    if (changes.Count > 0)
    {
     Console.WriteLine("{0} option labels for {1} entities were added to the cache.", changes.Count, entityMetadataCollection.Count);
     Console.WriteLine("{0} Option Labels cached", _optionLabelList.Count);
    }
    else
    { Console.WriteLine("No option labels were added to the cache."); }

   }
  }
  protected void removeOptionLabelsFromCache(DeletedMetadataCollection DeletedMetadata, Boolean showChanges)
  {
   List<OptionSetOption> optionSetOptionsToRemove = new List<OptionSetOption>();

   if (DeletedMetadata.Keys.Contains(DeletedMetadataFilters.OptionSet))
   {
    DataCollection<Guid> optionsetmetadataids = (DataCollection<Guid>)DeletedMetadata[DeletedMetadataFilters.OptionSet];
    foreach (Guid metadataid in optionsetmetadataids)
    {
     foreach (OptionSetOption oso in _optionLabelList)
     {
      if (metadataid == oso.optionsetId)
      {
       optionSetOptionsToRemove.Add(oso);
      }
     }
    }
   }
   foreach (OptionSetOption option in optionSetOptionsToRemove)
   {
    _optionLabelList.Remove(option);
   }
   if (showChanges)
   {
    if (optionSetOptionsToRemove.Count > 0)
    {
     Console.WriteLine("{0} Option Labels removed", optionSetOptionsToRemove.Count);
     Console.WriteLine("{0} Total Option Labels currently cached", _optionLabelList.Count);
     Console.WriteLine("");
    }
    else
    {
     Console.WriteLine("No Option Labels removed.");
     Console.WriteLine("");
    }

   }
  }
  
  protected void addCustomEntityWithOptionSet()
  {
   String primaryAttributeSchemaName = "sample_SampleEntityForMetadataQueryName";

   CreateEntityRequest createEntityRequest = new CreateEntityRequest
   {

    //Define the entity
    Entity = new EntityMetadata
    {
     SchemaName = _customEntitySchemaName,
     LogicalName = _customEntitySchemaName.ToLower(),
     DisplayName = new Label("Entity for MetadataQuery Sample", _languageCode),
     DisplayCollectionName = new Label("Entity for MetadataQuery Sample", _languageCode),
     Description = new Label("An entity created for the MetadataQuery Sample", _languageCode),
     OwnershipType = OwnershipTypes.UserOwned,
     IsVisibleInMobile = new BooleanManagedProperty(true),
     IsActivity = false,

    },

    // Define the primary attribute for the entity


    PrimaryAttribute = new StringAttributeMetadata
    {
     SchemaName = primaryAttributeSchemaName,
     LogicalName = primaryAttributeSchemaName.ToLower(),
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     MaxLength = 100,
     Format = StringFormat.Text,
     DisplayName = new Label("Entity for MetadataQuery Sample Name", _languageCode),
     Description = new Label("The primary attribute for the Bank Account entity.", _languageCode)
    }

   };
_service.Execute(createEntityRequest);


   //PublishXmlRequest publishXmlRequest = new PublishXmlRequest { ParameterXml = String.Format("<importexportxml><entities><entity>{0}</entity></entities></importexportxml>", _customEntitySchemaName.ToLower()) };
   //_service.Execute(publishXmlRequest);

   //Add an optionset attribute

   CreateAttributeRequest createAttributeRequest = new CreateAttributeRequest
   {
    EntityName = _customEntitySchemaName.ToLower(),
    Attribute = new PicklistAttributeMetadata
    {
     SchemaName = _customAttributeSchemaName,
     DisplayName = new Label("Example OptionSet for MetadataQuery Sample", _languageCode),
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),

     OptionSet = new OptionSetMetadata
     {
      IsGlobal = false,
      OptionSetType = OptionSetType.Picklist,
      Options =  { 
       new OptionMetadata(new Label("First Option",_languageCode),null),
       new OptionMetadata(new Label("Second Option",_languageCode),null),
       new OptionMetadata(new Label("Third Option",_languageCode),null),
       new OptionMetadata(new Label("Fourth Option",_languageCode),null)
      }
     }
    }
   };

   _service.Execute(createAttributeRequest);

  }

  protected void addOptionToCustomEntityOptionSet()
  {

   InsertOptionValueRequest insertOptionValueRequest =
    new InsertOptionValueRequest
    {
     AttributeLogicalName = _customAttributeSchemaName.ToLower(),
     EntityLogicalName = _customEntitySchemaName.ToLower(),
     Label = new Label("Fifth Option", _languageCode)
    };

   _service.Execute(insertOptionValueRequest);


  }


  protected void deleteCustomEntityWithOptionSet()
  {

   DeleteEntityRequest request = new DeleteEntityRequest()
   {
    LogicalName = _customEntitySchemaName.ToLower(),
   };
   _service.Execute(request);


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

  protected void publishUpdatedEntity()
  {
   PublishXmlRequest publishXmlRequest = new PublishXmlRequest
   {
    ParameterXml = "<importexportxml><entities><entity>" + _customEntitySchemaName.ToLower() + "</entity></entities></importexportxml>"
   };
   _service.Execute(publishXmlRequest);
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

    MetadataQuerySample app = new MetadataQuerySample();
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

 public class OptionSetOption {
  public OptionSetOption(Guid OptionsetId, int OptionValue, String Label)
 {
  this._optionsetId = OptionsetId;
  this._optionValue = OptionValue;
  this._label = Label;
 }
  
  private Guid _optionsetId;
  private int _optionValue;
  private String _label;

  public Guid optionsetId { get { return this._optionsetId; } }
  public int optionValue { get { return this._optionValue; } }
  public String label { get { return this._label; } }
 }


}

// </snippetmetadataquery>