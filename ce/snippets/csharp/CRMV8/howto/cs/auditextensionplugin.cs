// <snippetauditextensionplugin>


using System;

// These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
// located in the SDK\bin folder of the SDK download.
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

// The namespace providing the early binding for the custom entity
using AuditExtensionPlugin.Model;

namespace Microsoft.Crm.Sdk.Samples
{
    /// <summary>
    /// Demonstrates how to write a plugin that can enable read auditing.
    /// </summary>
    public class AuditExtensionPlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            #region service initializations

            IPluginExecutionContext pluginContext =
                serviceProvider.GetService(typeof(IPluginExecutionContext))
                as IPluginExecutionContext;

            var orgServiceFactory =
                serviceProvider.GetService(typeof(IOrganizationServiceFactory))
                as IOrganizationServiceFactory;
            IOrganizationService orgService = orgServiceFactory.CreateOrganizationService(
                pluginContext.UserId);

            #endregion

            // case for Retrieve message
            if (pluginContext.OutputParameters.Contains("BusinessEntity") &&
                pluginContext.OutputParameters["BusinessEntity"] is Entity)
            {
                var entity = ((Entity)pluginContext.OutputParameters["BusinessEntity"])
                    .ToEntityReference();
                RecordRead(orgService, entity, pluginContext.UserId);
            }
            // case for RetrieveMultiple message
            else if (pluginContext.OutputParameters.Contains("BusinessEntityCollection") &&
                pluginContext.OutputParameters["BusinessEntityCollection"] is EntityCollection)
            {
                var entities = (EntityCollection)pluginContext
                    .OutputParameters["BusinessEntityCollection"];
                foreach (var entity in entities.Entities)
                    RecordRead(orgService, entity.ToEntityReference(), pluginContext.UserId);
            }
        }

        private void RecordRead(IOrganizationService orgService, EntityReference entity, 
            Guid userId)
        {
            if (entity.LogicalName == sample_auditextension.EntityLogicalName)
                return; // don't log audit records about retrieving the audit records

            sample_auditextension record = new sample_auditextension()
            {
                sample_Action = new OptionSetValue((int)AuditAction.Retrieve),
                sample_Operation = new OptionSetValue((int)
                    sample_auditextension.sample_OperationValue.Retrieve),
                sample_CallingUserId = new EntityReference("systemuser", userId),
                sample_ObjectId = entity.Id.ToString().TrimEnd('}').TrimStart('{'),
                sample_ObjectLogicalName = entity.LogicalName,
                sample_UserId = new EntityReference("systemuser", userId),
                sample_name = String.Format("Retrieve of entity type {0} by user {1}",
                    entity.LogicalName, userId.ToString().TrimStart('{').TrimEnd('}'))
            };
            orgService.Create(record);
        }
    }
}

// </snippetauditextensionplugin>