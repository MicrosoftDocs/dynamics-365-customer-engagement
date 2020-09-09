// <snippetentityimages>


using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Discovery;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

// This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
// found in the SDK\bin folder.
using Microsoft.Crm.Sdk.Messages;

namespace Microsoft.Crm.Sdk.Samples
{
 /// <summary>
 /// Demonstrates how to do create and retrieve records with image data
 /// </summary>
 /// <remarks>
 /// At run-time, you will be given the option to delete all the
 /// database records created by this program.</remarks>
 public class EntityImages
 {
  #region Class Level Members
  private OrganizationServiceProxy _serviceProxy;
  private const String _customEntityName = "sample_ImageAttributeDemo";
  #endregion Class Level Members

  #region How To Sample Code
  /// <summary>
  /// This method first connects to the Organization service. Afterwards,
  /// a custom entity is created and configured to support entity images.
  /// Then records are created using this custom entity with image data. 
  /// The records are then retrieved and the resized images are saved.
  /// Finally, the custom entity can be deleted.
  /// </summary>
  /// <param name="serverConfig">Contains server connection information.</param>
  /// <param name="promptforDelete">When True, the user will be prompted to delete all
  /// created entities.</param>
  public void Run(ServerConnection.Configuration serverConfig, bool promptforDelete)
  {
   try
   {
    // Connect to the Organization service. 
    // The using statement assures that the service proxy will be properly disposed.
    using (_serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig))
    {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     Console.WriteLine("Please wait while the custom Image Attribute Demo entity used by this sample is created.");
     //Creates the Image Attribute Demo entity used in this sample
     CreateImageAttributeDemoEntity();

     //Create 5 records using different sized images.
     /*
      
      This sample uses late-binding because the entity was just created and is
      not included in the 'MyOrganizationsCrmSdkTypes.cs' file created by the 
      code generation tool (CrmSvcUtil.exe)
      
     */
     //Use a 144x144 pixel image
     Entity imageEntity1 = new Entity(_customEntityName.ToLower());
     imageEntity1["sample_name"] = "144x144.png";
     imageEntity1["entityimage"] = File.ReadAllBytes("Images\\144x144.png");
     Guid imageEntity1Id = _serviceProxy.Create(imageEntity1);
     ShowEntityFormInBrowser(promptforDelete, "144x144.png", imageEntity1Id);
     
     //Use a 144x400 pixel image
     Entity imageEntity2 = new Entity(_customEntityName.ToLower());
     imageEntity2["sample_name"] = "144x400.png";
     imageEntity2["entityimage"] = File.ReadAllBytes("Images\\144x400.png");
     Guid imageEntity2Id = _serviceProxy.Create(imageEntity2);     
     ShowEntityFormInBrowser(promptforDelete, "144x400.png", imageEntity2Id);
     
     //Use a 400x144 pixel image
     Entity imageEntity3 = new Entity(_customEntityName.ToLower());
     imageEntity3["sample_name"] = "400x144.png";
     imageEntity3["entityimage"] = File.ReadAllBytes("Images\\400x144.png");
     Guid imageEntity3Id = _serviceProxy.Create(imageEntity3);
     ShowEntityFormInBrowser(promptforDelete, "400x144.png", imageEntity3Id);

     //Use a 400x500 pixel image
     Entity imageEntity4 = new Entity(_customEntityName.ToLower());
     imageEntity4["sample_name"] = "400x500.png";
     imageEntity4["entityimage"] = File.ReadAllBytes("Images\\400x500.png");
     Guid imageEntity4Id = _serviceProxy.Create(imageEntity4);
     ShowEntityFormInBrowser(promptforDelete, "400x500.png", imageEntity4Id);

     //Use a 60x80 pixel image
     Entity imageEntity5 = new Entity(_customEntityName.ToLower());
     imageEntity5["sample_name"] = "60x80.png";
     imageEntity5["entityimage"] = File.ReadAllBytes("Images\\60x80.png");
     Guid imageEntity5Id = _serviceProxy.Create(imageEntity5);
     ShowEntityFormInBrowser(promptforDelete, "60x80.png", imageEntity5Id);
     Console.WriteLine();
     //Retrieve and download the binary images
     string binaryImageQuery =
String.Format(@"<fetch mapping='logical'>
  <entity name='{0}'>
    <attribute name='sample_name' />
    <attribute name='entityimage' />
  </entity>
</fetch>",_customEntityName.ToLower());

     EntityCollection binaryImageResults = _serviceProxy.RetrieveMultiple(new FetchExpression(binaryImageQuery));


     Console.WriteLine("Records retrieved and image files saved to: {0}", Directory.GetCurrentDirectory());
     foreach (Entity record in binaryImageResults.Entities)
     {
      String recordName = record["sample_name"] as String;
      String downloadedFileName = String.Format("Downloaded_{0}", recordName);
      byte[] imageBytes = record["entityimage"] as byte[];
      var fs = new BinaryWriter(new FileStream(downloadedFileName, FileMode.Append, FileAccess.Write));
      fs.Write(imageBytes);
      fs.Close();
      Console.WriteLine(downloadedFileName);
     }
     Console.WriteLine();
     //Retrieve and the records with just the url
     string imageUrlQuery =
String.Format(@"<fetch mapping='logical'>
  <entity name='{0}'>
    <attribute name='sample_name' />
    <attribute name='entityimage_url' />
  </entity>
</fetch>", _customEntityName.ToLower());

     EntityCollection imageUrlResults = _serviceProxy.RetrieveMultiple(new FetchExpression(imageUrlQuery));


     Console.WriteLine("These are the relative URLs for the images retrieved:");
     foreach (Entity record in imageUrlResults.Entities)
     {
      String imageUrl = record["entityimage_url"] as String;
      Console.WriteLine(imageUrl);
     }


     DeleteImageAttributeDemoEntity(promptforDelete);
    }
   }

   // Catch any service fault exceptions that Microsoft Dynamics CRM throws.
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault>)
   {
    // You can handle an exception here or pass it back to the calling method.
    throw;
   }
  }

  /// <summary>
  /// Creates any entity records that this sample requires.
  /// </summary>
  public void CreateImageAttributeDemoEntity()
  {
   //Create a Custom entity
   CreateEntityRequest createrequest = new CreateEntityRequest
   {

    //Define the entity
    Entity = new EntityMetadata
    {
     SchemaName = _customEntityName,
     DisplayName = new Label("Image Attribute Demo", 1033),
     DisplayCollectionName = new Label("Image Attribute Demos", 1033),
     Description = new Label("An entity created by an SDK sample to demonstrate how to upload and retrieve entity images.", 1033),
     OwnershipType = OwnershipTypes.UserOwned,
     IsActivity = false,

    },

    // Define the primary attribute for the entity
    PrimaryAttribute = new StringAttributeMetadata
    {
     SchemaName = "sample_Name",
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None),
     MaxLength = 100,
     FormatName = StringFormatName.Text,
     DisplayName = new Label("Name", 1033),
     Description = new Label("The primary attribute for the Image Attribute Demo entity.", 1033)
    }

   };
   _serviceProxy.Execute(createrequest);
   Console.WriteLine("The Image Attribute Demo entity has been created.");

   //Create an Image attribute for the custom entity
   // Only one Image attribute can be added to an entity that doesn't already have one.
   CreateAttributeRequest createEntityImageRequest = new CreateAttributeRequest
   {
    EntityName = _customEntityName.ToLower(),
    Attribute = new ImageAttributeMetadata
    {
     SchemaName = "EntityImage", //The name is always EntityImage
     //Required level must be AttributeRequiredLevel.None
     RequiredLevel = new AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), 
     DisplayName = new Label("Image", 1033),
     Description = new Label("An image to show with this demonstration.", 1033)

    }
   };
   _serviceProxy.Execute(createEntityImageRequest);
   Console.WriteLine("The Image attribute has been created.");

   QueryExpression qe = new QueryExpression("systemform");
   qe.Criteria.AddCondition("type", ConditionOperator.Equal, 2); //main form
   qe.Criteria.AddCondition("objecttypecode", ConditionOperator.Equal, _customEntityName.ToLower()); 
   qe.ColumnSet.AddColumn("formxml");

   SystemForm ImageAttributeDemoMainForm = (SystemForm)_serviceProxy.RetrieveMultiple(qe).Entities[0];

   XDocument ImageAttributeDemoMainFormXml = XDocument.Parse(ImageAttributeDemoMainForm.FormXml);
   //Set the showImage attribute so the entity image will be displayed
   ImageAttributeDemoMainFormXml.Root.SetAttributeValue("showImage", true);

   //Updating the entity form definition
   ImageAttributeDemoMainForm.FormXml = ImageAttributeDemoMainFormXml.ToString();

   _serviceProxy.Update(ImageAttributeDemoMainForm);
   Console.WriteLine("The Image Attribute Demo main form has been updated to show images.");


   PublishXmlRequest pxReq1 = new PublishXmlRequest { ParameterXml = String.Format(@"
   <importexportxml>
    <entities>
     <entity>{0}</entity>
    </entities>
   </importexportxml>", _customEntityName.ToLower()) };
   _serviceProxy.Execute(pxReq1);

   Console.WriteLine("The Image Attribute Demo entity was published");
  }


  public void ShowEntityFormInBrowser(bool prompt, String name, Guid id)
  {
   if (prompt)
   {
    Console.WriteLine("\nDo you want to view record '{0}' form? (y/n)", name);
    String viewFormAnswer = Console.ReadLine();
    if (viewFormAnswer.StartsWith("y") || viewFormAnswer.StartsWith("Y"))
    {
     try
     {
      String webServiceURL = _serviceProxy.EndpointSwitch.PrimaryEndpoint.AbsoluteUri;
      String entityInDefaultSolutionUrl = webServiceURL.Replace("XRMServices/2011/Organization.svc",
       String.Format("main.aspx?etn={0}&amp;pagetype=entityrecord&amp;id=%7B{1}%7D", _customEntityName.ToLower(),id.ToString()));

      ProcessStartInfo browserProcess = new ProcessStartInfo("iexplore.exe");
      browserProcess.Arguments = entityInDefaultSolutionUrl;
      Process.Start(browserProcess);

     }
     catch (SystemException)
     {
      Console.WriteLine("\nThere was a problem opening Internet Explorer.");
     }
    }
   }
  }

  /// <summary>
  /// Deletes any entity records that were created for this sample.
  /// <param name="prompt">Indicates whether to prompt the user 
  /// to delete the records created in this sample.</param>
  /// </summary>
  public void DeleteImageAttributeDemoEntity(bool prompt)
  {
   bool deleteRecords = true;

   if (prompt)
   {
    Console.WriteLine("\nDo you want to delete the entity created for this sample? (y/n) [y]: ");
    String answer = Console.ReadLine();

    deleteRecords = (answer.StartsWith("y") || answer.StartsWith("Y") || answer == String.Empty);
   }

   if (deleteRecords)
   {
    DeleteEntityRequest der = new DeleteEntityRequest() { LogicalName = _customEntityName.ToLower() };
    _serviceProxy.Execute(der);
    Console.WriteLine("The Image Attribute Demo entity has been deleted.");
   }
  }

  #endregion How To Sample Code

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

    EntityImages app = new EntityImages();
    app.Run(config, true);
   }

  
   catch (FaultException<Microsoft.Xrm.Sdk.OrganizationServiceFault> ex)
   {
    Console.WriteLine("The application terminated with an error.");
    Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp);
    Console.WriteLine("Code: {0}", ex.Detail.ErrorCode);
    Console.WriteLine("Message: {0}", ex.Detail.Message);
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
      Console.WriteLine("Trace: {0}", fe.Detail.TraceText);
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
  #endregion Main method
 }
}

// </snippetentityimages>