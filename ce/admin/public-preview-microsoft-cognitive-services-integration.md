---
title: "Microsoft Cognitive Services integration with Dynamics 365 for Customer Engagement| MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 49097a82-a7ea-46a8-b272-5d71137b835e
caps.latest.revision: 24
author: Mattp123
ms.author: matp
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Microsoft Cognitive Services integration

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This section describes how to integrate [!INCLUDE[pn_MicrosoftCognitiveServices_full](../includes/pn-microsoftcognitiveservices-full.md)] with Customer Engagement apps features.


> [!IMPORTANT]
> - [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] integration with Customer Engagement apps is only available for instances in the United States (US) region.  
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  
> - [!INCLUDE[cc_preview_features_send_us_feedback](../includes/cc-preview-features-send-us-feedback.md)]  

<a name="AboutAzureML"></a>   

## About Microsoft Cognitive Services  
[!INCLUDE[pn_MicrosoftCognitiveServices_full](../includes/pn-microsoftcognitiveservices-full.md)] includes several APIs that leverage the power of machine learning. Some [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps features can use the Text Analytics APIs to detect sentiment, key phrases, topics, and language from the text found in your [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps data.   

<a name="AboutAzureML"></a>   

## Set the text analytics connection  
[!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps features that  use the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service for keyword matching require a [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service connection. This connects [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps to the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service.  

1. Go to **Settings** > **Administration** > **Azure Text Analytics Service Configuration**.  

2. Review the information and click **Continue**.  

3. Next, fill in the connection information.  


   |             Item             |                                                                                                                                                                         Description                                                                                                                                                                         |
   |------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |       Name (required)        |                                                                                                                                                             A logical name for the connection.                                                                                                                                                              |
   | Azure Service URL (required) |                                                                                                         The service URL for the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service.                                                                                                          |
   | Azure Account Key (required) | You will need to sign up for the Text Analytics API and obtain an API key. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Signing up for Text Analytics API](https://docs.microsoft.com/azure/cognitive-services/text-analytics/how-tos/text-analytics-how-to-signup).  A $0.00 account is available for trying out this feature. |
   |         Description          |                                                                                                                                                              A description of the connection.                                                                                                                                                               |


4. Click **Test Connection** to validate your settings.  

5. Once the connection is successful, click **Activate**.  


## Privacy notice  
[!INCLUDE[cc_privacy_text_analytics](../includes/cc-privacy-text-analytics.md)]  


### See also  

[Use advanced similarity rules to view similar cases suggestions](../customer-service/suggest-similar-cases-for-a-case.md)

[Auto suggest knowledge articles](../admin/public-preview-automatically-suggest-knowledge-articles.md)

[Enable document suggestions](enable-document-suggestions.md)
