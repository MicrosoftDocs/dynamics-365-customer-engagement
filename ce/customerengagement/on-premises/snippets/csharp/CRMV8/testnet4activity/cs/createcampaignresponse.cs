// <snippetcreatecampaignresponse>


using System;
using System.Activities;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Xml;

using Microsoft.ServiceBus;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Workflow;

namespace Microsoft.Crm.Sdk.Samples
{
	public sealed partial class CreateCampaignResponse : CodeActivity
	{
		//internal static string CustomEntityName = "new_isvactivityverifier";
		protected override void Execute(CodeActivityContext executionContext)
		{
			IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
			IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);

			ServiceBusListener serviceBusListener = new ServiceBusListener();
			MessageBufferClient messageBufferClient = serviceBusListener.GetMessageBufferClient();

			Message message = null;

			try
			{
				message = messageBufferClient.Retrieve();
			}
			catch (FaultException)
			{
				//MessageBufferClient.Retrieve() will throw a timeout exception, if there are no packets to retrieve. So, do not throw if it is a TimeOutException.
				//if (!(fe.Message.Contains("Message could not be retrieved")))
				//{
				//    throw fe;
				//}
				//continue;
			}
			catch (Exception)
			{
				//MessageBufferClient.Retrieve() will throw a timeout exception, if there are no packets to retrieve. So, do not throw if it is a TimeOutException.
				//if (!(ex.GetType().Name.Equals("TimeoutException") && ex.Message.Equals("Message could not be retrieved: RequestTimeout, Request Timeout")))
				//{
				//    throw ex;
				//}
				//continue;					
			}

			foreach (MessageHeader header in message.Headers)
			{
				if (header.Name != "SecurityToken")
				{
					continue;
				}

				StringBuilder sb = new StringBuilder();
				var writer = XmlWriter.Create(sb);
				header.WriteHeader(writer, MessageVersion.Default);
				writer.Close();

				string headerString = sb.ToString();

				string startNode = "<SecurityToken xmlns=\"ns\">";
				int startIndex = headerString.IndexOf(startNode) + startNode.Length;
				int endIndex = headerString.LastIndexOf("</SecurityToken>");
				string tokenString = headerString.Substring(startIndex, endIndex - startIndex);

			}

			switch (message.Headers.Action)
			{
				case "https://schemas.microsoft.com/xrm/2011/Contracts/IServiceEndpointPlugin/Execute":
					ProcessMessages(message.GetBody<RemoteExecutionContext>(), service);
					break;
				//} //end - infinite for loop
			}
		}

		public static void ProcessMessages(RemoteExecutionContext context, IOrganizationService service)
		{
			Guid entityId = new Guid(context.SharedVariables["EntityId"].ToString());
			string entityType = context.SharedVariables["EntityType"].ToString();
			Guid campaignId = new Guid(context.SharedVariables["CampaignId"].ToString());
			Guid activityId = new Guid(context.SharedVariables["ActivityId"].ToString());

			Entity campresp = new Entity(EntityName.CampaignResponse);
			campresp[CampaignResponseAttributes.RegardingObjectId] = new EntityReference(EntityName.Campaign, campaignId);
			Entity customer = new Entity(EntityName.ActivityParty);
			customer[ActivityPartyAttributes.PartyId] = new EntityReference(entityType, entityId);
			campresp[CampaignResponseAttributes.Customer] = new EntityCollection(new Entity[] { customer });
			campresp[CampaignResponseAttributes.Subject] = "Response via matchpoint";
			service.Create(campresp);
		}
	}
}

// </snippetcreatecampaignresponse>