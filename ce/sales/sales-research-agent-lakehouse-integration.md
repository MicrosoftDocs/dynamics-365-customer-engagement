---
title: Connect Sales Research Agent to Microsoft Fabric Lakehouse (preview)
description: Discover how to connect to Microsoft Fabric Lakehouses for AI-powered data analysis. Ensure seamless access with inherited permissions and metadata-driven insights.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 02/05/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
---

# Connect Sales Research Agent to Microsoft Fabric Lakehouse (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

You can connect the Sales Research Agent to Microsoft Fabric Lakehouse to enable rich analysis over your enterprise data stored in OneLake. When you select the Lakehouse option, the Sales Research Agent automatically discovers Lakehouse shortcuts that you have permission to access and makes them available as data sources for AI-powered reasoning. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Considerations for using Sales Research Agent with Microsoft Fabric Lakehouse

When connecting Sales Research Agent to Microsoft Fabric Lakehouse, consider the following information:

- The agent uses your sign-in information for Dynamics 365 to authenticate to Microsoft Fabric. It uses your Entra ID (Azure AD) identity and inherits the same permissions you have in Fabric workspaces and OneLake. 

- The agent supports Lakehouse shortcuts. Shortcuts allow a Lakehouse to reference data stored elsewhere (for example, another OneLake location or Azure Data Lake Storage). The agent can surface and query data through these shortcuts as long as the signed-in user has read permissions on the shortcut target. 

- The agent only shows Lakehouses and Lakehouse shortcuts that you already have access to. If you don't see a Lakehouse option, it could be because of one of the following reasons:

    - You don't have Fabric enabled in your tenant.  
    - You don't have access to any workspaces that contain a Lakehouse or Lakehouse shortcut.
    - Your admin has restricted Fabric access controls. 

- The agent depends on the Lakehouse metadata to find relevant data. These metadata include: 

    - Table and column names 
    - Directory structure within the “Tables” area of the Lakehouse  

    The more descriptive your metadata, the better Sales Research Agent can reason over your data. 

- The agent respects all Fabric and OneLake access controls. The agent can only read data that: 
    
    - Exists inside Lakehouse *Tables* (Delta Lake/Parquet) or shortcut-mounted folders 
    - The signed-in user has permission to read
    - Isn't blocked by workspace or item-level security settings 

- If row-level or column-level security is enforced through a semantic model, that security is also applied. 

- The connection has similar constraints as other large enterprise data connections. The agent may limit the number of tables scanned at once or the volume of raw data materialized depending on internal system limits. 

- If you don't have at least **Viewer** access to the workspace containing the Lakehouse, the agent won't show the option to connect. In this case, contact your Fabric administrator to grant the necessary permissions. 

## How administrators manage access

Microsoft Fabric administrators manage Lakehouse access using standard Fabric and OneLake security controls. Learn more in the [Microsoft Fabric documentation](/fabric/data-engineering/workspace-roles-lakehouse). The following permissions are important for Sales Research Agent to access Lakehouse data:

1. **Workspace permissions:** You need Viewer, Contributor, or Admin permissions at the Workspace level. 

1. **Item-level permissions:** Lakehouses support item-level access controls. You must have explicit permission to the Lakehouse itself even if you have workspace access. 

1. **OneLake permissions for shortcuts:** For shortcuts that reference external storage: 

    - You must have access to the *target* location (for example, another Lakehouse, an ADLS Gen2 folder).  
    - If you can't access the shortcut target, Sales Research Agent can't surface or use that data. 
    
1. **Data governance and security policies:** You must have access to the data within the Lakehouse according to your organization's governance policies. This access is determined by a combination of:

    - Fabric data permissions 
    - Purview policies    
    - Row-level security (RLS) and column-level security (CLS) when exposed through semantic models 

## What Sales Research Agent never bypasses 

Sales Research Agent is designed with security and compliance in mind. It  always operates under the user’s security context and never bypasses or elevates permissions. The agent strictly adheres to the following access controls:

- Workspace roles 
- OneLake ACLs and shortcut access permissions 
- Item-level Fabric permissions 
- RLS/CLS 
    
## How Sales Research Agent processes your Lakehouse query

When you query your Lakehouse, the Sales Research Agent performs the following steps to ensure secure and relevant data retrieval:

1.  Enumerates Lakehouses and shortcuts the signed-in user can access. 

1.  Uses metadata, such as table names, folder names, schema information, and descriptions, to identify relevant data. 

1.  Generates safe, read-only queries against Lakehouse Tables or Files folders. 

1.  Applies all Fabric and OneLake permissions before returning data.