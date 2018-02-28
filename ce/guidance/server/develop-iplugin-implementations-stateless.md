---
title: "Develop IPlugin implementations as stateless | MicrosoftDocs"
description: "Members of classes that implement IPlugin are exposed to potential thread-safety issues which could lead to data inconsistency or performance problems."
ms.date: 02/05/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: c34cc738-8c42-4dc8-8c34-1167d00a5f67
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---
# Develop IPlugin implementations as stateless

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Design, Performance

**Impact potential**: High

<a name='symptoms'></a>

## Symptoms

Members of classes that implement the <xref href="Microsoft.Xrm.Sdk.IPlugin?text=IPlugin interface" /> are exposed to potential thread-safety issues which could lead to:

- Data inconsistencies
- Slower plugin executions

<a name='guidance'></a>

## Guidance

When implementing <xref:Microsoft.Xrm.Sdk.IPlugin>, do not use member fields and properties and write the <xref:Microsoft.Xrm.Sdk.IPlugin.Execute*> method as a stateless operation.  All per invocation state information should be accessed via the execution context only.  Do not attempt to store any execution state data in member fields or properties for use during the current or next plug-in invocation unless that data was obtained from the configuration parameter provided to the overloaded constructor.

Read-only, static, and constant members are inherently thread-safe and can also be used reliably within a plug-in class. The following are some examples on how to maintain thread-safe plug-ins:

- Constant field members

    ```csharp
    public class Valid_ClassConstantMember : IPlugin
    {
        public const string validConstantMember = "Plugin registration not valid for {0} message.";

        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));

            if (context.MessageName.ToLower() != "create")
                throw new InvalidPluginExecutionException(String.Format(Valid_ClassConstantMember.validConstantMember, context.MessageName));
        }
    }
    ```

- Storing configuration data assigned or set in plug-in class constructor
    ```csharp
    public class Valid_ClassFieldConfigMember : IPlugin
    {
        private string validConfigField;

        public Valid_ClassFieldConfigMember(string unsecure, string secure)
        {
            this.validConfigField = !String.IsNullOrEmpty(secure)
                ? unsecure
                : secure;
        }

        public void Execute(IServiceProvider serviceProvider)
        {
            if (!String.IsNullOrEmpty(this.validConfigField))
            {
                var message = ValidHelperMethod();
            }
        }

        private string ValidHelperMethod()
        {
            return String.Format("{0} is the config value.", this.validConfigField);
        }
    }
    ```

- Stateless method implementation

    ```csharp
    public class Valid_ClassStatelessMethodMember : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
    
            if (ValidMemberMethod(context))
            {
                //Then continue with execution
            }
        }
    
        private bool ValidMemberMethod(IPluginExecutionContext context)
        {
            if (context.MessageName.ToLower() == "create")
                return true;
            else
                return false;
        }
    }
    ```

<a name='problem'></a>

## Problematic patterns

> [!WARNING]
> These patterns should be avoided.

- Assigning plug-in class field member during plug-in execution
 
    ```csharp
    public class Violation_ClassAssignFieldMember : IPlugin
    {
        //The instance member used in multiple violation patterns
        internal IOrganizationService service = null;
        internal IPluginExecutionContext context = null;
    
        public void Execute(IServiceProvider serviceProvider)
        {
            this.context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
    
            //The violation
            this.service = factory.CreateOrganizationService(this.context.UserId);
    
            //Invoke another violation in method member
            AccessViolationProperties();
        }
    
        private void AccessViolationProperties()
        {
            //Accessing the context and service fields exposes this IPlugin implementation to thread-safety issues
            var entity = new Entity("task");
            entity["regardingid"] = new EntityReference(this.context.PrimaryEntityName, this.context.PrimaryEntityId);
    
            var id = this.service.Create(entity);
        }
    }
    ```

- Setting plug-in class property member during plug-in execution

    ```csharp
    public class Violation_ClassAssignPropertyMember : IPlugin
    {
        //The instance member used in multiple violation patterns
        internal IOrganizationService Service { get; set; }
        internal IPluginExecutionContext Context { get; set; }
    
        public void Execute(IServiceProvider serviceProvider)
        {
            this.Context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
    
            //The violation
            this.Service = factory.CreateOrganizationService(context.UserId);
    
            //Invoke another violation in method member
            AccessViolationProperties();
        }
    
        private void AccessViolationProperties()
        {
            //Accessing the Context and Service properties exposes this IPlugin implementation to thread-safety issues
            var entity = new Entity("task");
            entity["regardingid"] = new EntityReference(this.Context.PrimaryEntityName, this.Context.PrimaryEntityId);
    
            var id = this.Service.Create(entity);
        }
    }
    ```

<a name='additional'></a>

## Additional information

After [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] instantiates the plug-in class, the platform caches that plug-in instance for performance reasons. The length of time that a plug-in instance is held in cache is managed by the platform.  Certain operations, such as changing a plug-in's registration properties, will trigger a notification to the platform to refresh the cache.  In these scenarios, the plug-in will be reinitialized.

Because the [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] platform caches plug-in class instances, the constructor is not called for every invocation of plug-in execution.  For this reason, IPlugin implementations should not depend on the timing of operations in the constructor apart from obtaining static configuration data. 

Another reason IPlugins should be stateless is that multiple system threads could execute the same, shared, plug-in instance concurrently.  This opens up members of classes that implement IPlugin to potential thread-safety issues which could lead to data inconsistency or performance problems.

<a name='seealso'></a>

### See also

[Writing A Basic Plug-in](../../developer/write-plugin.md#writing-a-basic-plug-in)<br />
[CRM Team Blog: Thread Safety in Plug-ins](http://blogs.msdn.com/b/crm/archive/2008/11/18/member-static-variable-and-thread-safety-in-plug-in-for-crm-4-0.aspx)<br />