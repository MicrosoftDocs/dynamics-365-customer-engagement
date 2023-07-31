---
title: Add an authentication setting for Nuance Gatekeeper (preview)
description: How-to add authentication settings for Nuance Gatekeeper 
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 07/31/2023
ms.custom: bap-template 
---

# Add authentication setting for Nuance Gatekeeper (preview)

> [!IMPORTANT]
> [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

## Prerequisites

- Nuance Gatekeeper instance is provisioned.
- Omnichannel for Customer Service with the voice channel is provisioned.
- Azure Communication Services must be configured on the Customer Service tenant.
- OpenID basic configuration in the Azure Active Directory to allow single sign-on process for the administrator, fraud analyst credentials, and Nuance portals.
- Azure Service Principal for Conversation Conductor and Omnichannel Event Grid Writer are provisioned.
- The following information is shared by the Nuance Gatekeeper team:
  - Gatekeeper Client ID and Client Secret.
  - Gatekeeper Scope ID, such as b6f1a330-xxxx-xxxx-a03c-387ac9axxxxx.
  - Gatekeeper Config Set ID, such as ContactCenterDemo.

### Check for Azure tenant requirement

The Customer Service instance and the Azure Communication Services resource that's connected to the organization must be in the same Azure tenant. We also recommend that the Azure Communication Services resource used for Customer Service instance that's using Gatekeeper be isolated in their own Azure subscription.

To verify, do the following steps:

1. In Customer Service admin center, go to the workstream and voice channel you'll use.
1. Verify that the Customer Service instance and Azure Communication Services resource with phone numbers are using the same tenant.

If your Customer Service instance isn't in the same tenant, you can't register the new service components that share the audio stream between the Digital Contact Center Platform and Nuance Gatekeeper. Instead, you'll see an error message when you try to  create the authentication setting.

### Create application registration for single sign-on

You'll need to do some of the Gatekeeper actions in the Nuance portals. To simplify access and credentials, the Nuance Gatekeeper team configures single sign-on access to your Azure Active Directory, so that you can use your regular username and password to access the functionality.

Create a new application registration in your Azure Active Directory and share the OpenID Connect metadata document by following these steps:

1. Go to [Azure portal](https://portal.azure.com).
1. Select **Azure Active Directory** in the site map.
1. On the **Azure Active Directory** page, select **App registrations** in the site map.
1. If you're an existing Nuance Gatekeeper customer, you probably have a registered app for Nuance Gatekeeper. Search in the **All applications** tab for Nuance Gatekeeper. If you don’t have it registered, do the following steps:
   1. Select **New registration**.
   1. Type the name **Nuance Gatekeeper** for your app registration, and select **Register** at the bottom of the page. After the app is registered, the **App Registration Details** page appears.
1. Select **Endpoints** to get the URL needed for single sign-on.
1. On the **Endpoints** page, copy the value in the **OpenID Connect metadata document** field.

## Add the authentication setting for Gatekeeper

1. In the Customer Service admin center site map, select **Customer Settings** in **Customer support**. The **Customer settings** page appears.  
1. In **Authentication settings**, select **Manage**. The **Authentication settings** page appears.
1. Select **New Authentication Settings**, and provide the following information on the **Add authentication setting** page:
    - **Name**: Enter a name for the authentication setting.
    - **Channel type**: Select **Voice call**.
    - **Authentication type**: **Gatekeeper Biometric Authentication** is selected and not editable.
1. Select **Next**.
1. On the **Details** page, enter the following information:

   - **Endpoint region**: Is selected as US and not editable.
   - **Client ID**: The Nuance Gatekeeper client ID.
   - **Client Secret**: The Nuance Gatekeeper client secret.
   - **Scope ID**: The Nuance Gatekeeper scope ID.
   - **Config Set ID**: The Nuance Gatekeeper config set ID.
1. Save and close.

Apart from the default ID, you can optionally configure another ID to uniquely identify the contact between the Omnichannel and Nuance platforms. Do the following steps to configure another ID:

1. On the **Create new authentication setting** page, expand **Gatekeeper integration advanced settings**.
1. Select **Contact (ContactId)** and **Account (AccountId)** in **Contact** and **Account** fields.

   >[!NOTE]
   > You can't edit the contact and account fields after the authentication setting is created.

After you select save and close, the components will be provisioned and your settings tested. Errors at this step means either the settings aren't correct, or the Azure Communication Services resources are running in a different Azure tenant from your Dynamics 365 environment.

## Configure a workstream and authentication option

In Customer Service admin center, do the following steps:

1. Select an existing voice workstream or perform the steps in [Create and manage workstreams](create-workstreams.md) to create a voice workstream.
1. Edit the phone number setting of the voice workstream, and select the **Behaviors** tab.
1. Scroll down and turn on the toggle for **Authentication (preview)**.
1. Select the authentication option for Gatekeeper in **Authentication setting** and select **Save**.

## Exclude a conversation from being authenticated

You can configure classification rules to exclude a conversation from the authentication process.

Do the following steps:

1. Configure a [context variable](manage-context-variables.md#add-context-variables) with the name "NuanceGatekeeperEnabled" and of the Number type.
1. Configure a [work classification rule](configure-work-classification.md) for the workstream through which the conversation will be handled. Ensure that the output value for the context variable is set to zero. When it’s set to zero, the conversation is excluded from the authentication process.

  :::image type="content" source="media/exclude-conversation-from-gatekeeper-authentication.png" alt-text="Configure routing rules to exclude a conversation from biometric authentication by Nuance Gatekeeper.":::

> [!NOTE]
> The routing rule isn’t evaluated for transferred calls or supervisor-assigned calls.

### How the conversation is excluded from authentication process

After you configure the setting to exclude the customer call, when the call comes, on the call panel, the agent will see a message that authentication is unavailable for the call or the authentication is not available by design.

## Next steps

[Configure digital contact center for Nuance Gatekeeper integration](configure-contact-center-nuance-gatekeeper.md)  

### See also

[Introduction to Nuance Gatekeeper integration](nuance-gatekeeper-introduction.md)  