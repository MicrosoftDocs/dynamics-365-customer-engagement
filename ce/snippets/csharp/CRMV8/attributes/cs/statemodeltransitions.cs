// <snippetstatemodeltransitions>



using System;
using System.Linq;
using System.Xml.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// found in the SDK\bin folder.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Metadata.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
 class StateModelTransitions
 {
  #region Class Level Members
  /// <summary>
  /// Stores the organization service proxy.
  /// </summary>
  OrganizationServiceProxy _serviceProxy;
  #endregion Class Level Members

  #region How To Sample Code
  /// <summary>
  /// Create and configure the organization service proxy.
  /// Retrieve status options for the Incident entity
  /// Use GetValidStatusOptions to get valid status transitions for each status option
  /// </summary>
  /// <param name="serverConfig">Contains server connection information.</param>
  /// <param name="promptForDelete">When True, the user will be prompted to delete all
  /// created entities.</param>
  public void Run(ServerConnection.Configuration serverConfig, bool promptForDelete)
  {
   try
   {

    // Connect to the Organization service. 
    // The using statement assures that the service proxy will be properly disposed.
    using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
    {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();
     String entityLogicalName = "incident";
     // Retrieve status options for the Incident entity

     //Retrieve just the incident entity and its attributes
     MetadataFilterExpression entityFilter = new MetadataFilterExpression(LogicalOperator.And);
     entityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
     MetadataPropertiesExpression entityProperties = new MetadataPropertiesExpression(new string[] { "Attributes" });
     
     //Retrieve just the status attribute and the OptionSet property
     MetadataFilterExpression attributeFilter = new MetadataFilterExpression(LogicalOperator.And);
     attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status));
     MetadataPropertiesExpression attributeProperties = new MetadataPropertiesExpression(new string[] { "OptionSet" });
     
     //Instantiate the entity query
     EntityQueryExpression query = new EntityQueryExpression()
     {
      Criteria = entityFilter,
      Properties = entityProperties,
      AttributeQuery = new AttributeQueryExpression() { Criteria = attributeFilter, Properties = attributeProperties }
     };

     //Retrieve the metadata
     RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest() { Query = query };
     RetrieveMetadataChangesResponse response = (RetrieveMetadataChangesResponse)_serviceProxy.Execute(request);


     StatusAttributeMetadata statusAttribute = (StatusAttributeMetadata)response.EntityMetadata[0].Attributes[0];
     OptionMetadataCollection statusOptions = statusAttribute.OptionSet.Options;
     //Loop through each of the status options
     foreach (StatusOptionMetadata option in statusOptions)
     {
      String StatusOptionLabel = GetOptionSetLabel(statusAttribute, option.Value.Value);
      Console.WriteLine("[{0}] {1} records can transition to:", StatusOptionLabel, entityLogicalName);
      List<StatusOption> validStatusOptions = GetValidStatusOptions(entityLogicalName, option.Value.Value);
      //Loop through each valid transition for the option
      foreach (StatusOption opt in validStatusOptions)
      {
       Console.WriteLine("{0,-3}{1,-10}{2,-5}{3,-10}", opt.StateValue, opt.StateLabel, opt.StatusValue, opt.StatusLabel);
      }
      Console.WriteLine("");
     }
    }
   }

   // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
   {
    // You can handle an exception here or pass it back to the calling method.
    throw;
   }
  }


  #endregion How To Sample Code

  #region Main
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

    StateModelTransitions app = new StateModelTransitions();
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

     FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> fe
         = ex.InnerException
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
  #endregion Main

  #region Methods used in Sample
  /// <summary>
  /// Returns valid status option transitions regardless of whether state transitions are enabled for the entity
  /// </summary>
  /// <param name="entityLogicalName">The logical name of the entity</param>
  /// <param name="currentStatusValue">The current status of the entity instance</param>
  /// <returns>A list of StatusOptions that represent the valid transitions</returns>
  public List<StatusOption> GetValidStatusOptions(String entityLogicalName, int currentStatusValue)
  {

   List<StatusOption> validStatusOptions = new List<StatusOption>();

   //Check entity Metadata

   //Retrieve just one entity definition
   MetadataFilterExpression entityFilter = new MetadataFilterExpression(LogicalOperator.And);
   entityFilter.Conditions.Add(new MetadataConditionExpression("LogicalName", MetadataConditionOperator.Equals, entityLogicalName));
   //Return the attributes and the EnforceStateTransitions property
   MetadataPropertiesExpression entityProperties = new MetadataPropertiesExpression(new string[] { "Attributes", "EnforceStateTransitions" });

   //Retrieve only State or Status attributes
   MetadataFilterExpression attributeFilter = new MetadataFilterExpression(LogicalOperator.Or);
   attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.Status));
   attributeFilter.Conditions.Add(new MetadataConditionExpression("AttributeType", MetadataConditionOperator.Equals, AttributeTypeCode.State));

   //Retrieve only the OptionSet property of the attributes
   MetadataPropertiesExpression attributeProperties = new MetadataPropertiesExpression(new string[] { "OptionSet" });

   //Set the query
   EntityQueryExpression query = new EntityQueryExpression()
   {
    Criteria = entityFilter,
    Properties = entityProperties,
    AttributeQuery = new AttributeQueryExpression() { Criteria = attributeFilter, Properties = attributeProperties }
   };

   //Retrieve the metadata
   RetrieveMetadataChangesRequest request = new RetrieveMetadataChangesRequest() { Query = query };
   RetrieveMetadataChangesResponse response = (RetrieveMetadataChangesResponse)_serviceProxy.Execute(request);

   //Check the value of EnforceStateTransitions
   Boolean? EnforceStateTransitions = response.EntityMetadata[0].EnforceStateTransitions;

   //Capture the state and status attributes
   StatusAttributeMetadata statusAttribute = new StatusAttributeMetadata();
   StateAttributeMetadata stateAttribute = new StateAttributeMetadata();

   foreach (AttributeMetadata attributeMetadata in response.EntityMetadata[0].Attributes)
   {
    switch (attributeMetadata.AttributeType)
    {
     case AttributeTypeCode.Status:
      statusAttribute = (StatusAttributeMetadata)attributeMetadata;
      break;
     case AttributeTypeCode.State:
      stateAttribute = (StateAttributeMetadata)attributeMetadata;
      break;
    }
   }


   if (EnforceStateTransitions.HasValue && EnforceStateTransitions.Value == true)
   {
    //When EnforceStateTransitions is true use the TransitionData to filter the valid options
    foreach (StatusOptionMetadata option in statusAttribute.OptionSet.Options)
    {
     if (option.Value == currentStatusValue)
     {
      if (option.TransitionData != String.Empty)
      {
       XDocument transitionData = XDocument.Parse(option.TransitionData);

       IEnumerable<XElement> elements = (((XElement)transitionData.FirstNode)).Descendants();

       foreach (XElement e in elements)
       {
        int statusOptionValue = Convert.ToInt32(e.Attribute("tostatusid").Value);
        String statusLabel = GetOptionSetLabel(statusAttribute, statusOptionValue);

        string stateLabel = String.Empty;
        int? stateValue = null;
        foreach (StatusOptionMetadata statusOption in statusAttribute.OptionSet.Options)
        {
         if (statusOption.Value.Value == statusOptionValue)
         {
          stateValue = statusOption.State.Value;
          stateLabel = GetOptionSetLabel(stateAttribute, stateValue.Value);
         }

        }


        validStatusOptions.Add(new StatusOption()
        {
         StateLabel = stateLabel,
         StateValue = stateValue.Value,
         StatusLabel = statusLabel,
         StatusValue = option.Value.Value
        });
       }
      }
     }
    }

   }
   else
   {
    ////When EnforceStateTransitions is false do not filter the available options

    foreach (StatusOptionMetadata option in statusAttribute.OptionSet.Options)
    {
     if (option.Value != currentStatusValue)
     {

      String statusLabel = "";
      try
      {
       statusLabel = option.Label.UserLocalizedLabel.Label;
      }
      catch (Exception)
      {
       statusLabel = option.Label.LocalizedLabels[0].Label;
      };

      String stateLabel = GetOptionSetLabel(stateAttribute, option.State.Value);

      validStatusOptions.Add(new StatusOption()
      {
       StateLabel = stateLabel,
       StateValue = option.State.Value,
       StatusLabel = statusLabel,
       StatusValue = option.Value.Value

      });
     }
    }
   }
   return validStatusOptions;

  }

  /// <summary>
  /// Returns a string representing the label of an option in an optionset
  /// </summary>
  /// <param name="attribute">The metadata for an attribute with options</param>
  /// <param name="value">The value of the option</param>
  /// <returns>The label for the option</returns>
  public String GetOptionSetLabel(EnumAttributeMetadata attribute, int value)
   {
    String label = "";
    foreach (OptionMetadata option in attribute.OptionSet.Options)
    {
     if (option.Value.Value == value)
     {
      try
      {
       label = option.Label.UserLocalizedLabel.Label;
      }
      catch (Exception)
      {
       label = option.Label.LocalizedLabels[0].Label;
      };
     }
    }
    return label;
   }
  #endregion Methods used in Sample
 }
 public class StatusOption
 {
  public int StatusValue { get; set; }
  public String StatusLabel { get; set; }
  public int StateValue { get; set; }
  public String StateLabel { get; set; }
 }
}

// </snippetstatemodeltransitions>