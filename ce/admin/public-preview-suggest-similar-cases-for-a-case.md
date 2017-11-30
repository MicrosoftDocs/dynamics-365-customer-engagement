---
title: "Preview feature: Suggest similar cases for a case with Dynamics 365 Customer Engagement| MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 91e10e68-8edf-4eee-a69e-9d9b6fac16f9
caps.latest.revision: 9
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Preview feature: Suggest similar cases for a case

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]
[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You're working on a support case and you wonder if there's a similar case that might help you resolve yours. With [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_MicrosoftCognitiveServices_full](../includes/pn-microsoftcognitiveservices-full.md)] Text Analytics, you can quickly find related cases and use them to resolve your current case. Keywords or key phrases  in a service case are used to find similar cases.  
  
> [!IMPORTANT]
> - This feature is currently only available for instances in the United States (US) region.  
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  
>   
> **Send us feedback**  
>   
>  We'd love your feedback on the suggest similar cases feature! To send us your feedback, register your account on the [Microsoft Connect site](https://connect.microsoft.com/site687), and then [submit your feedback](https://connect.microsoft.com/site687/Feedback/LoadSubmitFeedbackForm?FormID=5908).  
  
<a name="BKMK_EnablePreview"></a>   

## Enable Text Analytics  
 To enable Text Analytics, do the following:  
  
1. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
2.  Click **System Settings** and open the **Previews** tab.  
  
3.  Under **Text Analytics Preview for Case Topic analysis, Suggest Similar Cases and Suggest Knowledge Articles**, set the **Enable Dynamics 365 Text Analytics Preview** to **Yes**.  
  
4.  Click **OK** to give your consent.  
  
5.  Click **OK** to close the **System Settings** dialog.  
  
<a name="BKMK_ConnectTextAnalytics"></a>   

## Connect Dynamics 365 (online) to the Cognitive Services Text Analytics service  
 If you haven't already, create the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service connection. [Set the Azure Machine Learning text analytics connection](../admin/public-preview-microsoft-cognitive-services-integration.md#Set_AzureMLconnection)  
  
<a name="BKMK_SetUpSimilarCase"></a>   

## Define and activate similarity rules  
 If you have not already defined similarity rules, see [Create similar record suggestion rules](../admin/public-preview-microsoft-cognitive-services-integration.md#create_similar_record_rules). For this feature, you need to select Case as the Source Entity for the similarity rule.  
  
<a name="BKMK_SeeRelatedCases"></a>   

## See related cases  
 After configuring the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service and setting up similar records suggestions, you're ready to see cases related to the ones you're working on.  
  
1.  Click **Service** > **Cases** and open a case.  
  
2.  For similar cases, click **Find**.  
  
 ![Find similar cases](../admin/media/find-similar-cases.png "Find similar cases")  
  
3.  Click a case title to review that case's posts, activities, and notes. Then click **Found a Solution!** to add a  case with useful information to the **Similar Cases** area (under **Case Relationships**) to the case you're working on.  
  
<a name="BKMK_ISHSearch"></a>   
## See related cases in the interactive service hub  
 The interactive service hub  unifies vital information in one place, and lets you focus on things that require your attention, like finding articles and cases related to your active case.  
  
1.  Open the interactive service hub. See [Open the interactive service hub](../customer-service/user-guide-customer-service.md).  
  
2.  Click **Service** > **Cases** and open a case.  
  
3.  Click the **Similar Cases** button to find related cases.  
  
 ![Interactive Service Hub similar cases](../admin/media/interactive-service-hub-similar-cases.png "Interactive Service Hub similar cases")  
  
### See also  
 [User's guide for the new interactive service hub](../customer-service/user-guide-customer-service.md)   
