// <snippettestisvactivities>


using System;
using System.Activities;
using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using Microsoft.Crm.Sdk.Messages;

using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Workflow;

namespace Microsoft.Crm.Sdk.Samples
{
	public sealed class GlobalOptionSetActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			return;
		}

		[Input("qooi_pricingerrorcode")]
		[AttributeTarget("quote", "pricingerrorcode")]
		public InArgument<OptionSetValue> GlobalValue { get; set; }
	}

	public sealed class OutputContext : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			IWorkflowContext wfContext = context.GetExtension<IWorkflowContext>();

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("The following Values were in the InputParameters:");
			foreach (KeyValuePair<string, object> pair in wfContext.InputParameters)
			{
				sb.AppendLine(pair.Key);
			}

			sb.AppendLine("The following Values were in the OutputParameters:");
			foreach (KeyValuePair<string, object> pair in wfContext.OutputParameters)
			{
				sb.AppendLine(pair.Key);
			}

			IOrganizationServiceFactory factory = context.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = factory.CreateOrganizationService(null);

			Task e = new Task();
			e.Subject = "Context";
			e.Description = sb.ToString();
			e.RegardingObjectId = new EntityReference(wfContext.PrimaryEntityName, wfContext.PrimaryEntityId);

			service.Create(e);
		}
	}

	[Persist]
	public sealed partial class CreateCustomEntity : CodeActivity
	{
		internal static string CustomEntityName = "new_isvactivityverifier";
		protected override void Execute(CodeActivityContext executionContext)
		{
			IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
			IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);

			Entity de = new Entity(CustomEntityName);

			if (myBoolean != null)
			{
				de["new_boolean"] = myBoolean.Get(executionContext);
			}
			if (myDateTime != null)
			{
				de["new_datetime"] = myDateTime.Get(executionContext);
			}
			if (myDecimal != null)
			{
				de["new_decimal"] = myDecimal.Get(executionContext);
			}
			if (myFloat != null)
			{
				de["new_float"] = myFloat.Get(executionContext);
			}
			if (myLookup != null)
			{
				de["new_lookup"] = "Type = " + myLookup.Get(executionContext).LogicalName + " Value = " + myLookup.Get(executionContext).Id;
			}
			if (myMoney != null)
			{
				de["new_money"] = myMoney.Get(executionContext);
			}
			if (myNumber != null)
			{
				de["new_number"] = myNumber.Get(executionContext);
			}
			if (myPicklist != null)
			{
				de["new_picklist"] = myPicklist.Get(executionContext);
			}
			if (myStatus != null)
			{
				de["new_status"] = myStatus.Get(executionContext).Value.ToString();
			}
			if (myString != null)
			{
				de["new_stringtext"] = myString.Get(executionContext);
			}

			de["new_activationid"] = context.OwningExtension.Id.ToString();

			myOutLookup.Set(executionContext, new EntityReference(CustomEntityName, service.Create(de)));
		}

		[Output("My Output Lookup")]
		[ReferenceTarget("new_isvactivityverifier")]
		public OutArgument<EntityReference> myOutLookup { get; set; }

		[Input("My Integer")]
		public InArgument<int> myNumber { get; set; }

		[Input("My String")]
		public InArgument<string> myString { get; set; }

		[Input("My Boolean")]
		public InArgument<bool> myBoolean { get; set; }

		[Input("My Lookup")]
		[ReferenceTarget("account")]
		public InArgument<EntityReference> myLookup { get; set; }

		[Input("My Picklist")]
		[AttributeTarget("account", "industrycode")]
		public InArgument<OptionSetValue> myPicklist { get; set; }

		[Input("My DateTime")]
		public InArgument<DateTime> myDateTime { get; set; }

		[Input("My Decimal")]
		public InArgument<decimal> myDecimal { get; set; }

		[Input("My Money")]
		public InArgument<Money> myMoney { get; set; }

		[Input("My Float")]
		public InArgument<double> myFloat { get; set; }

		[Input("My Status")]
		[AttributeTarget("account", "statuscode")]
		public InArgument<OptionSetValue> myStatus { get; set; }
	}

	[Persist]
	public sealed partial class ParameterActivity : CodeActivity
	{
		internal static string CustomEntityName = "new_isvactivityverifier";
		protected override void Execute(CodeActivityContext executionContext)
		{
		}

		public OutArgument<IServiceProvider> OutProvider { get; set; }

		public InArgument<IServiceProvider> InProvider { get; set; }

		public InOutArgument<IServiceProvider> InOutProvider { get; set; }

		[Output("My Output int")]
		public OutArgument<int> OutInteger { get; set; }

		[Input("My Input int with incorrect attribute")]
		public OutArgument<int> InInteger { get; set; }

		[Input("My Input/Output int")]
		[Output("My Input/Output int")]
		public InOutArgument<int> InOutInteger { get; set; }
	}

	[Persist]
	public sealed partial class ExecuteChildWorkflowActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			IOrganizationServiceFactory factory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = factory.CreateOrganizationService(null);

			ExecuteWorkflowRequest request = new ExecuteWorkflowRequest();
			request.EntityId = this.Target.Get(executionContext).Id;
			request.WorkflowId = this.Workflow.Get(executionContext).Id;

			service.Execute(request);
		}

		[Input("Target Entity")]
		[ReferenceTarget("account")]
		[RequiredArgument]
		public InArgument<EntityReference> Target { get; set; }

		[Input("Child Workflow")]
		[ReferenceTarget("workflow")]
		[RequiredArgument]
		public InArgument<EntityReference> Workflow { get; set; }
	}

	public sealed partial class AuditActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			IWorkflowContext context = executionContext.GetExtension<IWorkflowContext>();
			IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = serviceFactory.CreateOrganizationService(context.InitiatingUserId);

			Entity entity = new Entity(EntityName.Task);
			entity[TaskAttributes.Subject] = "UserId: " + context.InitiatingUserId.ToString();
			service.Create(entity);
		}
	}

	public sealed partial class ThrowException : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			Type exType = null;

			Assembly assembly = Assembly.Load(AssemblyName.Get(executionContext));
			exType = assembly.GetType(ExceptionType.Get(executionContext));

			if (exType != null)
			{
				ConstructorInfo ci = exType.GetConstructor(new Type[] { typeof(string) });
				throw (Exception)ci.Invoke(new object[] { "Called From ISV Activity Throw Exception" });
			}
			else
			{
				throw new ArgumentException(String.Format("Did not find Exception {0} in any of the assemblies",
					ExceptionType.Get(executionContext)));
			}
		}

		[Input("Exception Type")]
		public InArgument<string> ExceptionType { get; set; }

		[Input("Assembly Name")]
		public InArgument<string> AssemblyName { get; set; }
	}

	public sealed partial class SleepForXSeconds : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			if (SleepDurationInSeconds == null || SleepDurationInSeconds.Get(executionContext) < 0)
			{
				throw new ArgumentException("Sleep Time Cannot be less than zero");
			}

			System.Threading.Thread.CurrentThread.Join(SleepDurationInSeconds.Get(executionContext) * 1000);
		}

		[Input("Sleep Time in Seconds")]
		public InArgument<int> SleepDurationInSeconds { get; set; }
	}

	#region No-Op Activities per DataType

	public sealed partial class NoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Integer")]
		[Output("My Integer Output")]
		public InOutArgument<int> myNumber { get; set; }

		[Input("My String")]
		[Output("My String Output")]
		public InOutArgument<string> myString { get; set; }

		[Input("My Boolean")]
		[Output("My Boolean Output")]
		public InOutArgument<bool> myBoolean { get; set; }

		[Input("My Lookup")]
		[ReferenceTarget("account")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }

		[Input("My Picklist")]
		[AttributeTarget("account", "industrycode")]
		[Output("My Picklist Output")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }

		[Input("My DateTime")]
		[Output("My DateTime Output")]
		public InOutArgument<DateTime> myDateTime { get; set; }

		[Input("My Decimal")]
		[Output("My Decimal Output")]
		public InOutArgument<decimal> myDecimal { get; set; }

		[Input("My Money")]
		[Output("My Money Output")]
		public InOutArgument<Money> myMoney { get; set; }

		[Input("My Float")]
		[Output("My Float Output")]
		public InOutArgument<double> myFloat { get; set; }

		[Input("My Status")]
		[AttributeTarget("account", "statuscode")]
		[Output("My Status Output")]
		public InOutArgument<OptionSetValue> myStatus { get; set; }
	}

	public sealed partial class StringNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My String")]
		[Output("My String Output")]
		public InOutArgument<string> myString { get; set; }
	}

	public sealed partial class CrmNumberNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Integer")]
		[Output("My Integer Output")]
		public InOutArgument<int> myNumber { get; set; }
	}

	public sealed partial class CrmBooleanNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Boolean")]
		[Output("My Boolean Output")]
		public InOutArgument<bool> myBoolean { get; set; }
	}

	public sealed partial class LookupAccountNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("account")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupUserNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("systemuser")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupLeadNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("lead")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupQueueNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("queue")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupTeamNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("team")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupTaskNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("task")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class LookupPhoneCallNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("phonecall")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class PicklistNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Picklist")]
		[AttributeTarget("account", "industrycode")]
		[Output("My Picklist Output")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }
	}

	public sealed partial class CrmDateTimeNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			if (null == this.myDateTime)
			{
				return;
			}

			if (null != this.myDateTime)
			{
				this.DateTimeKind.Set(context, myDateTime.Get(context).Kind.ToString());
			}
		}

		[Input("My DateTime")]
		[Output("My DateTime Output")]
		public InOutArgument<DateTime> myDateTime { get; set; }

		[Output("DateTime Kind")]
		public OutArgument<string> DateTimeKind { get; set; }
	}

	public sealed partial class CrmDecimalNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Decimal")]
		[Output("My Decimal Output")]
		public InOutArgument<decimal> myDecimal { get; set; }
	}

	public sealed partial class CrmMoneyNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Money")]
		[Output("My Money Output")]
		public InOutArgument<Money> myMoney { get; set; }
	}

	public sealed partial class CrmFloatNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Float")]
		[Output("My Float Output")]
		public InOutArgument<double> myFloat { get; set; }
	}

	public sealed partial class OwnerNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Owner")]
		[ReferenceTarget("systemuser")]
		[Output("My Owner Output")]
		public InOutArgument<EntityReference> myOwner { get; set; }
	}

	public sealed partial class StatusNoOpActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Status")]
		[AttributeTarget("account", "statuscode")]
		[Output("My Status Output")]
		public InOutArgument<OptionSetValue> myStatus { get; set; }
	}

	#endregion No-Op Activities per DataType

	#region Default Values per DataType
	public sealed partial class DefaultValueTestActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Integer")]
		[Output("My Integer Output")]
		[Default("2322")]
		public InOutArgument<int> myNumber { get; set; }

		[Input("My String")]
		[Output("My String Output")]
		[Default("My Default String")]
		public InOutArgument<string> myString { get; set; }

		[Input("My Boolean")]
		[Output("My Boolean Output")]
		[Default("True")]
		public InOutArgument<bool> myBoolean { get; set; }

		[Input("My Lookup")]
		[ReferenceTarget("account")]
		[Output("My EntityReference Output")]
		//[Default("5BC2D0C1-3371-DC11-BA09-0019B9279BFB", "account")]
		public InOutArgument<EntityReference> myLookup { get; set; }

		[Input("My Picklist")]
		[AttributeTarget("account", "industrycode")]
		[Output("My Picklist Output")]
		[Default("3")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }

		[Input("My DateTime")]
		[Output("My DateTime Output")]
		[Default("2004-07-09T02:54:02Z")]
		public InOutArgument<DateTime> myDateTime { get; set; }

		[Input("My Decimal")]
		[Output("My Decimal Output")]
		[Default("23.45")]
		public InOutArgument<decimal> myDecimal { get; set; }

		[Input("My Money")]
		[Output("My Money Output")]
		[Default("232.3")]
		public InOutArgument<Money> myMoney { get; set; }

		[Input("My Float")]
		[Output("My Float Output")]
		[Default("252.2")]
		public InOutArgument<double> myFloat { get; set; }

		[Input("My Status")]
		[AttributeTarget("account", "statuscode")]
		[Output("My Status Output")]
		[Default("1")]
		public InOutArgument<OptionSetValue> myStatus { get; set; }
	}

	#endregion No-Op Activities per DataType

	public class ActivityOnlyNameNoGroup : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Output("Test 123")]
		public OutArgument<int> Test123 { get; set; }
	}

	public class ActitvityNoInputParamsOnlyOutput : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			TodayMarketClose.Set(executionContext, new Random().Next(0, 100000));
		}

		[Output("Today's Market Close")]
		public OutArgument<int> TodayMarketClose { get; set; }
	}

	#region Error Activities

	public sealed partial class LookupWithMultipleCrmReferenceTargetsActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("contact")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public sealed partial class PicklistWithNoCrmAttributeTargetActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Picklist")]
		[Output("My Picklist Output")]
		[AttributeTarget("account", "customertypecode")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }
	}

	public sealed partial class PicklistWithAttributeNotPicklistCrmAttributeTargetActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Picklist")]
		[Output("My Picklist Output")]
		[AttributeTarget("account", "name")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }
	}

	public sealed partial class PicklistWithInvalidEntityCrmAttributeTargetActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Picklist")]
		[Output("My Picklist Output")]
		[AttributeTarget("erwerwa", "name")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }
	}

	public sealed partial class PicklistWithInvalidCrmAttributeTargetActivity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Picklist")]
		[Output("My Picklist Output")]
		[AttributeTarget("account", "dfwerw")]
		public InOutArgument<OptionSetValue> myPicklist { get; set; }
	}

	public class ActivityEmptyNoName : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}
	}

	public class ActivityNameWithSpecialCharacters : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Output("Output Value")]
		[Input("Input Value")]
		public InOutArgument<int> TodayMarketClose { get; set; }
	}

	public class ActivityInputParamNameWithSpecialCharacters : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("~!@#$%^&amp;*()_+\\][{}|:;'\"<>?/.,")]
		public InArgument<int> TodayMarketClose { get; set; }
	}

	public class ActivityOutputParamNameWithSpecialCharacters : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Output("~!@#$%^&amp;*()_+\\][{}|:;'\"<>?/.,")]
		public OutArgument<int> TodayMarketClose { get; set; }
	}

	public class ActivityWithLookupOnCustomEntity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("new_workflowtestparent")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public class ActivityWithLookupAndNoCrmReferenceTarget : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	public class ActivityWithLookupCrmReferenceTargetBadEntity : CodeActivity
	{
		protected override void Execute(CodeActivityContext context)
		{
			//Do nothing
		}

		[Input("My Lookup")]
		[ReferenceTarget("jibjab")]
		[Output("My EntityReference Output")]
		public InOutArgument<EntityReference> myLookup { get; set; }
	}

	#endregion

	#region Workflow Context Tests
	public sealed partial class AccessDifferentOrg : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			Guid differentOrgId = new Guid("368977ac-6034-40de-9060-2692a479f0bf");
			Guid userId = new Guid("66B3193E-4D6D-DC11-BA09-0019B9279BFB");
			IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = serviceFactory.CreateOrganizationService(userId);

			Entity de = new Entity(EntityName.Task);
			de[TaskAttributes.Subject] = "Task created from Factory's Proxy";

			service.Create(de);
		}
	}

	public sealed partial class UseMetadataService : CodeActivity
	{
		protected override void Execute(CodeActivityContext executionContext)
		{
			IWorkflowContext workflowContext = executionContext.GetExtension<IWorkflowContext>();
			IOrganizationServiceFactory serviceFactory = executionContext.GetExtension<IOrganizationServiceFactory>();
			IOrganizationService service = serviceFactory.CreateOrganizationService(workflowContext.InitiatingUserId);

			RetrieveEntityRequest req = new RetrieveEntityRequest();
			req.LogicalName = "account";
			RetrieveEntityResponse resp = (RetrieveEntityResponse)service.Execute(req);

			myString.Set(executionContext, resp.EntityMetadata.PrimaryNameAttribute);
		}

		[Output("My String Output")]
		public OutArgument<string> myString { get; set; }
	}
	#endregion

}

// </snippettestisvactivities>