---
title: "Enable third-party co-browse | MicrosoftDocs"
description: "Instructions to enable third-party co-browse between agents and customers."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 01/20/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Enable third-party co-browse

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions. If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

Co-browse is an escalation channel in the Chat channel of Microsoft Dynamics 365. A co-browse escalation channel allows your organization’s agents to start a co-browse session with customers. Using co-browse, agents can see and interact with a customer’s web browser or mobile application. This provides customers with an extra option to connect to an agent who can efficiently troubleshoot issues in real time.
For this private preview, co-browse is enabled within the Omnichannel Chat channel by integrating with ISVs.  We’ll provide the extensibility to let any providers to onboard their co-browse solution to Omnichannel. For this private preview, you will need to contact occob@microsoft.com to complete the integration. 

Prerequisites:
- An active chat subscription
- Channel Integration Framework solution with version 2.0 and above. Instructions to import the solution are in *Deploying CIF Package using Package Deployer.pdf.*

## Install the Conversation Control Actions solution

The Conversation Control Actions solution is required to use third-party co-browse for your organization. Import msdyn_OmnichannelCCA_managed.zip solution by following instructions - https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/customize/import-update-upgrade-solution.

## Install the third-party co-browse solution and configure the required forms

We provided two ways for you to obtain the needed data for co-browse: 
- (Recommended) Install the Omnichannel Integrated co-browse solution with required data.
-	Install the normal co-browse solution and create the records yourself.

(Recommended) Install the co-browse solution, which includes required data for the integration. The solution includes the following records: Conversation Control Action record, Provider record, and Application Tab Template record. You need to install Conversation Control Actions solution before you install the co-browse solution, as these records have dependencies on the entities in the Conversation Control Actions solution. 

Alternatively, you can configure the forms and create the records yourself by doing the following:

1.	Sign into Dynamics 365 for customer service and go to Channel Integration Framework.
2.	Go to Templates > Application Tabs.
3.	Select New to create a channel application tab.
4.	In Application type field, select webresource.
5.	In the Parameters section, add the web resource URL and query parameters that are required for ISVs to open their web resources.
    data: Input the value “{data}” as shown in the following screenshot
    webresourcename: <URL path to the web resource>
    
    [img]
    
6.	In Omnichannel Administration, go to Settings > Co-Browse Providers.
7.	Select New to create a provider and Save.
8.	Click Related and go to the Conversation Control Actions tab to create a new Action, click + New Conversation Control Action.
9.	Fill in the details of the action 
    1.	Action Label: label that will appear on the co-browse button
    1.	Action Resource: name of the Application Tab Template created in step 5. Make sure the Action Resource matches the name in the Application Tab Template record that you previously created.
    
    [img]
    
10.	View the action on the Conversation Control Actions tab.

    [img]
    
## Add the co-browse enabled channel API
If you used the recommended method (install co-browse solution) to create the required records in the previous step, the following URL can be used as the provided URL for the steps below: <INSERT URL>

Otherwise, to enable co-browse on Conversation Control widget, reach out to occob@microsoft.com with the following information from Conversation Control Actions:
1.	Action Resource
2.	Action Label (Ex: Co-browse)

You will receive a providedURL that will point to the newly created Conversation Control. 
The provided URL will need to be placed into the Omnichannel Channel Provider. This can be done by following these steps:
1.	Navigate to the Channel Integration Framework
2.	Select Channel Providers in the side bar
3.	Open Omnichannel channel provider
4.	In the Channel URL field, you will see a value of the form:
    https://oc-cdn-ocprod.azureedge.net/convcontrol/ChatControl.htm?uci=true&clientName=zfp&cloudType=Public&env=prod&ocBaseUrl=<orgBaseURL>&ucilib=<scriptBaseURL>
5.	Replace the highlighted section of the above value with the URL provided.
6.	The final value should be of the form: 
    <providedURL>?uci=true&clientName=zfp&cloudType=Public&env=prod&ocBaseUrl=<orgBaseURL>&ucilib=<scriptBaseURL>
After following the above steps, a button with the provided Action Label should be visible in your organization’s conversation control, similar to the following screenshot: 

[img]

### See also 
[How to get Dynamics 365 Channel Integration Framework](../channel-integration-framework/get-channel-integration-framework.md]
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Configure download and email of chat transcripts](download-email-chat-transcripts.md) <br>
[Configure file attachment capability](configure-file-attachment.md) <br>
