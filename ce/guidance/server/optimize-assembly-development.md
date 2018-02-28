---
title: "Optimize assembly development | MicrosoftDocs"
description: "Consider merging separate plug-ins/custom workflow activities into a single assembly to improve performance and maintainability and move plug-ins/custom workflow activities into multiple assemblies if an assembly size is near the sandbox assembly size constraints."
ms.date: 01/26/2018
ms.service: "crm-online"
ms.topic: "article"
applies_to: 
	- "Dynamics 365 (online)"
ms.assetid: df857a79-cf68-4c45-a058-3833afc637b7
author: "jowells1"
ms.author: "jowells"
manager: "michu"
---

[//]: <> (1/10/2018 - Version 1 release without a few questions needing answers.  Adding Guidance request Tasks to backlog for User Story 836096)

# Optimize assembly development

**Applies to**:

- [!include[](../../includes/pn-crm-9-0-0-online.md)]
- [!include[](../../includes/pn-crm-2016.md)]
- [!include[](../../includes/pn-crm-8-1-0-both.md)]
- [!include[](../../includes/pn-crm-2015.md)]
- [!include[](../../includes/pn-crmv6.md)]
- [!include[](../../includes/pn-crm-2011.md)]

**Category**: Performance, Maintainability, Design

**Impact potential**: Low

<a name='symptoms'></a>

## Symptoms

When developing assemblies for [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)], there are a couple of considerations to take in:

1. Multiple different assemblies
    - Increased maintainability complexity
    - Potential increase plug-in execution length

2. Sandbox assembly size constraint is 16 MB in [!INCLUDE [pn-dynamics-crm-online](../../includes/pn-dynamics-crm-online.md)] and, by default, 8 MB in [!INCLUDE [pn-dyn-365-op](../../includes/pn-dyn-365-op.md)].

<a name='guidance'></a>

## Guidance

> [!NOTE]
> Further Guidance clarification is under development regarding specific details in optimizing assembly development, such as, how to merge separate plug-ins into a single assembly and suggestions to minimize the assembly size.

### Consolidate Plug-ins or Custom Workflow Activities into a Single Assembly

Plug-ins and custom workflow activities developed for a [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] solution should exist with others in a single [!INCLUDE [pn-visual-studio](../../includes/pn-visual-studio.md)] project. Consider merging separate plug-ins/custom workflow activities into a single [!INCLUDE [pn-visual-studio](../../includes/pn-visual-studio.md)] project/assembly unless the plug-ins fall into the following exceptions:

[//]: <> (1/10/2018 - @Michu, should we add a note bubble about not using ILMerge and the lack of support for doing so?  Is this another Guidance rule we should look for and is there any thumbprint we can look for to indicate ILMerge occurred?)

[//]: <> (1/10/2018 - Need guidance on the appropriate way of merging plug-in assemblies.  Is it a manual process of trying to copy over class files and then manually bringing in dependencies?)

1. A plug-in/custom workflow activity needs to be selectively deployed to one environment but not to others.

2. The physical assembly size is near or greater than 16 MB for a [!INCLUDE [pn-dynamics-crm-online](../../includes/pn-dynamics-crm-online.md)] instance or, by default, 8 MB in [!INCLUDE [pn-dyn-365-op](../../includes/pn-dyn-365-op.md)].

> [!IMPORTANT]
> [!INCLUDE [pn-dyn-365-op](../../includes/pn-dyn-365-op.md)] deployments can identify the assembly size constraint by executing the following SQL query
>```sql
    USE MSCRM_CONFIG
    SELECT ColumnName, IntColumn FROM DeploymentProperties
    WHERE ColumnName = 'SandboxClientMaxAssemblySizeInKByte'
>```

[//]: <> (Not able to validate that this can be set via PowerShell. As far as I can tell, the only way to modify this setting is via SQL script.  Will need to confirm.)

### Move Plug-ins/Custom Workflow Activities into Multiple Assemblies

[!INCLUDE [pn-dynamics-crm-online](../../includes/pn-dynamics-crm-online.md)] has an assembly size constraint of 16 MB which cannot be changed. If your assembly size is nearing 16 MB, consider moving plug-in/custom workflow activities into multiple assemblies.

[//]: <> (1/11/2018 - Need guidance on the appropriate way of splitting plug-in assemblies.)

<a name='problem'></a>

## Problematic patterns

### Multiple assemblies
Having multiple assemblies has a couple of areas that can be impacted:

1. Performance - each assembly has a lifecycle that is managed by the [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] service.  This includes loading, caching, and unloading the assemblies.  Having more than one assembly causes more work to be done on the server, loading and caching an assembly, and could affect the overall plug-in/custom workflow activity execution length.

2. Maintainability - having more than one plug-in/custom workflow activity [!INCLUDE [pn-visual-studio](../../includes/pn-visual-studio.md)] project leads to more complex application lifecycle management (ALM). It increases the risk and the amount of time when updating/patching the appropriate project for a specific plug-in/custom workflow activity, packaging the plug-ins/custom workflow activities within a solution, and managing plug-ins/custom workflow activities within a deployment.

[//]: <> (1/10/2018 - Do we show screenshots of what this looks like?)

### Assembly larger than 16 MB
You will not be able to register an assembly within [!INCLUDE [pn-dynamics-crm-online](../../includes/pn-dynamics-crm-online.md)] that is larger than 16 MB.

<a name='additional'></a>

## Additional information

Quite often, [!INCLUDE [pn-dynamics-365](../../includes/pn-dynamics-365.md)] developers create a new [!INCLUDE [pn-visual-studio](../../includes/pn-visual-studio.md)] project for each plug-in/custom workflow activity.  In turn, this causes a separate assembly to be generated for each plug-in/custom workflow activity.

<a name='seealso'></a>

### See also

[Event execution pipeline](../../developer/event-execution-pipeline.md)<br />
[Plug-in Assemblies](../../developer/write-plugin.md#plug-in-assemblies)<br />
