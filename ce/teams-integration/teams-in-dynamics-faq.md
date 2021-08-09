---
title: "FAQ on Teams integration  | MicrosoftDocs"
description: "Collaborate efficiently in Dynamics 365 without switching to Teams. This page include FAQs about the integration."
ms.date: 08/13/2021
ms.topic: article
ms.service: crm-online
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# FAQ on Dynamics 365 integration with Teams 

## When is the tenant admin required?

The tenant admin will be required to provide the initial consent for the integration. After the tenant admin provides the consent, a system administrator can enable the integration at the instance-level.

## What happens when the consent is provided?

When the tenant admin provides the consent, an enterprise application called **Dynamics 365 Microsoft Teams Collaboration Integration** is created in Azure AD and permissions are given to the enterprise application. Also a flag is set internally in Dynamics 365 to indicate that the feature is enabled. This flag controls the UI behavior, such as displaying the **Collaborate** menu in the command bar.

## What is the scope of the consent?

The consent is given at tenant-level. It applies to all Dynamics 365 instances under the same tenant.

## After the consent is provided, is the Teams integration enabled for all instances?

No. After the tenant admin provides the consent, a Dynamics 365 system administrator can enable the integration for any instance under the same tenant.

## Which tenant admin is required for providing consent? 

You must be a global admin to provide the consent.

## What are the privileges and type of permissions required by the integration?
  
| **Permission**      | **Type**    | **What the app does with the permission**                                                                                                                                                                                                                                                                            |
|---------------------|-------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Chat.ReadWrite.All  | Delegated   | Reads user's chats and recent messages to display in chat list.                                                                                                                                                                                                                                                       |
| Directory.Read.All  | Delegated   | Reads user's teams and channels display name.                                                                                                                                                                                                                                                                         |
| Presence.Read.All   | Delegated   | Reads presence information of all users to be displayed on the user avatars in chat list.                                                                                                                                                                                                                             |
| User.Read.All       | Application | Reads display name and licenses of users to validate if the suggested participants have a Teams license assigned. This permission is used by the **Suggested chats and contacts** section in the chat list. The permission is set at the application-level as it's being used a background service for better performance. |
| User.ReadBasic.All  | Delegated   | Reads users' photos.                                                                                                                                                                                                                                                                                                  |

## Are any other services than Teams affected?

No other Office services are affected as Teams is managing these services on its own.
Therefore, they don’t need explicit consent.

## Will the integration in any way impact security constraints or configuration in Dynamics 365 and Teams?  

No. The integration is developed with the core principle of not violating security in any direction. Linking a chat or channel does not automatically grant participants of those chats or channels access to that Dynamics record.  Dynamics security roles & permissions will supersede any membership of a linked chat or channel. Similarly, the user trying to create a Team and/or channel from the **Collaborate** experience in Dynamics 365 must have Teams permissions to do so.


## Is the Teams conversation data stored in Dynamics 365?

Only the conversation ID is stored in Dynamics 365 using a link entity to make the connection between the record and the conversation. No conversation text will be stored in Dynamics 365.
 
