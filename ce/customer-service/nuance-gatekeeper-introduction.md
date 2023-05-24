---
title: Introduction to Nuance Gatekeeper 
description: Learn about the Nuance Gatekeeper 
author: neeranelli 
ms.author: nenellim 
ms.reviewer: sujoshi 
ms.topic: how-to 
ms.collection: 
ms.date: 05/24/2023
ms.custom: bap-template
---

# Introduction to Nuance Gatekeeper

As we move forward into an AI world with increased speed, experiences have become more seamless and less manual labor is necessary for everyone. This is true about the experiences tied to call centers and customer care too. 

Nuance Gatekeeper is a biometric authentication and fraud prevention technology that can be integrated with Microsoft Dynamics 365 Customer Service. It offers a streamlined verification process that allows contact centers to identify customers through natural conversation without relying on specific questions, security codes, or secret questions and answers. 

By using voice biometrics, Nuance Gatekeeper can quickly and accurately verify a customer's identity, significantly reducing the risk of fraud and protecting customers' personal data from unauthorized access. The integration with Nuance Gatekeeper helps agents deliver efficient, personalized service and helps fraud teams prevent, detect, and investigate more fraud. 

## How Nuance Gatekeeper works in Customer Service 

After Nuance Gatekeeper is integrated with the voice channel, it analyzes how a person sounds, how they talk, while characterizing their device, network, location, and other factors for signs of fraud. All of this happens seamlessly in the background of each engagement, so your customers can get the service they need without remembering passcodes, PINs, or security questions. 

Nuance Gatekeeper uses deep neural networks to determine a single, transparent authentication decision for every engagement. The platform is built on the following pillars of biometric security and AI decision-making: 

- **Voice**: Authenticate customers based on the distinct characteristics of their voice, regardless of age or language. 
- **Channel**: Identify device, ANI, channel, location, and network to flag suspicious signals such as hidden network origins, SIM swapping, and spoofing. 
- **AI risk engine**: Deep neural networks analyze interactions to determine true matches and prevent fraud. 

## Prerequisites

- Nuance Gatekeeper instance should be provisioned. 
- Omnichannel for Customer Service with the voice channel is provisioned. 
- Azure Communication Services must be configured on the Customer Service tenant. 
- OpenID basic configuration in the Azure Active Directory to allow single sign-on process between the administrator, fraud analyst credentials and Nuance portals. 
- Azure Service Principal for Conversation Conductor and Omnichannel Event Grid Writer are provisioned. 
- The following information is available (sent by Nuance Gatekeeper to the customer): 
    - Gatekeeper Client ID and Client Secret 
    - Gatekeeper Scope ID, such as b6f1a330-xxxx-xxxx-a03c-387ac9axxxxx. 
    - Gatekeeper Config Set ID, such as ContactCenterDemo. 

## Prerequisite checks

The following section summarizes the steps you must perform to ensure that all of the prerequisite conditions are met.

### Check for Azure tenant requirement 

The Dynamics environment and the Azure Communication Service resource connected to the organization must be in the same Azure tenant. We recommend that the Azure Communication Services resource used for Dynamics 365 environment using Gatekeeper be isolated in their own Azure subscription.  

To verify if the Azure Communication Services resource is in the same tenant as the Dynamics 365 environment, do the following steps: 

1. In Customer Service admin center, go to the workstream and voice channel you will use for the private preview. 
1. Verify if existing Dynamics 365 environments are using Azure resources under the same tenant as the Azure Communication Services resource with phone numbers. A screenshot for reference is as follows. 

If your Dynamics 365 instance is not under the same Azure tenant, the integration for Nuance Gatekeeper won’t be able to register the new service components that share the audio stream between Digital Contact Center Platform and Nuance Gatekeeper. Instead, you will notice an error message when you trying to create the Authentication Setting

### Create application registration for single sign-on 

Some of the Gatekeeper actions need to be performed in Nuance portals. To simplify access and credentials, the Nuance Gatekeeper team configures single sign-on access to your Azure Active Directory, so that you can use your regular username and password to access the functionality.

To achieve that, you need to create a new application registration in your Azure Active Directory and share the OpenID Connect metadata document by following these steps: 

1. Go to [Azure portal](https://portal.azure.com).
1. Select **Azure Active Directory** in the site map. 
1. On the **Azure Active Directory** page, select **App registrations** in the site map.
1. If you are an existing Nuance Gatekeeper customer, you probably have a registered app for Nuance Gatekeeper. Search in the **All applications** tab for Nuance Gatekeeper. If you don’t have it registered, create a new registration by selecting **New registration**.
1. Type the name **Nuance Gatekeeper** for your app registration and select **Register** at the bottom of the page.  
After the app is registered, the App Registration Details page appears. 
1. Select **Endpoints** to get the URL needed for single sign on. 
1. On the **Endpoints** page, copy the value in the **OpenID Connect metadata document** field and submit the information to Microsoft. 


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
