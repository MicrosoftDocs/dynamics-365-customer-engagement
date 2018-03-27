---
title: "Preview feature: Microsoft Cognitive Services integration with Dynamics 365 Customer Engagement| MicrosoftDocs"
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
ms.assetid: 49097a82-a7ea-46a8-b272-5d71137b835e
caps.latest.revision: 24
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Preview feature: Microsoft Cognitive Services integration

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

This section describes how to integrate [!INCLUDE[pn_MicrosoftCognitiveServices_full](../includes/pn-microsoftcognitiveservices-full.md)] with [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] features, such as similar cases and suggest knowledge articles.  

  
> [!IMPORTANT]
> - [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] integration with [!INCLUDE[pn_crm_online_shortest](../includes/pn-crm-online-shortest.md)] is only available for instances in the United States (US) region.  
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]  
> - [!INCLUDE[cc_preview_features_no_MS_support](../includes/cc-preview-features-no-ms-support.md)]  
> - [!INCLUDE[cc_preview_features_send_us_feedback](../includes/cc-preview-features-send-us-feedback.md)]  
   
<a name="AboutAzureML"></a>   

## About Microsoft Cognitive Services  
[!INCLUDE[pn_MicrosoftCognitiveServices_full](../includes/pn-microsoftcognitiveservices-full.md)] includes several APIs that leverage the power of machine learning. Some [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] features can use the Text Analytics APIs to detect sentiment, key phrases, topics, and language from the text found in your [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] data.   
  
<a name="Set_AzureMLconnection"></a>   

## Set the text analytics connection  
[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] features that  use the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service for keyword matching, like [!INCLUDE[cc_Document_Suggestions](../includes/cc-document-suggestions.md)], similar cases, and knowledge article suggestions, require a [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service connection. This connects [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service.  
  
1.  Go to **Settings** > **Administration** > **Azure Text Analytics Service Configuration**.  
  
2.  Review the information and click **Continue**.  
  
3.  Next, fill in the connection information.  
  
    |Item|Description|  
    |----------|-----------------|  
    |Name (required)|A logical name for the connection.|  
    |Azure Service URL (required)|The service URL for the [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics service.|  
    |Azure Account Key (required)|You will need to sign up for the Text Analytics API and obtain an API key. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Signing up for Text Analytics API](https://docs.microsoft.com/en-us/azure/cognitive-services/text-analytics/how-tos/text-analytics-how-to-signup).  A $0.00 account is available for trying out this feature.|  
    |Description|A description of the connection.|  
  
4.  Click **Test Connection** to validate your settings.  
  
5.  Once the connection is successful, click **Activate**.  
  
  
<a name="create_similar_record_rules"></a>   
## Create similar record suggestion rules  
 Set up automatic suggestion of similar records by creating rules. The rules you create can use either [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics or some features let you use the built-in similarities matching  engine in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Notice that you can only create one similar records suggestions rule for each entity type.  
  
1.  Go to **Settings** > **Data Management** > **Similar Records Suggestions Settings**.  
  
2.  Click **New**.  
  
3.  Fill in the fields on the New Advanced Similarity Rule dialog.  
  
    |Item|Description|  
    |----------|-----------------|  
    |Name (required)|The name of the topic model.|  
    |Source Entity (required)|The entity for which similar records are suggested.  Select either Account, Case, Contact, Lead, Opportunity, or a custom entity that has an N:N relationship with one of the entities supported for similarity rules.|  
    |Description|A description of the similarity rule.|  
    |Use Text Analytics for Target Match|Default: **No**. Will use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for keyword matching.<br /><br /> However, if you are using [!INCLUDE[pn_CognitiveServices_short](../includes/pn-microsoftcognitiveservices-short.md)] Text Analytics, set this to **Yes**. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set the text analytics connection](#Set_AzureMLconnection)|  
    |Filter Result by Status|Filter records by status. For example, you can filter Lead records on Qualified while ignoring Open and Disqualified Lead records.|  
    |**Advanced Text Match Settings**||  
    |Maximum Number of Key Phrases (required)|The maximum number of keywords or key phrases to be determined with text searches. Acceptable values are 0 to 1,000.|  
  
 ![Text Analytics similarity rule configuration](../admin/media/text-analytics-similarityruleconfig.PNG "Text Analytics similarity rule configuration")  
  
4.  Click **Save**.  
  
5.  For opportunity similarity rules, notice that sample mappings are already added. To add a mapping, scroll down to **Match Fields**, and then click New (![Add button](../admin/media/nb-ua-r1-plus.png "Add button")).  
  
6.  In the New Text Analytics page, enter values for the following fields. These values are used to determine the keywords or key phrases from source records using text analytics to match with target records using text search. This helps to achieve keyword-based similarity between source and target records.  
  
    |Item|Description|  
    |----------|-----------------|  
    |Criteria|Exact match: only fields from the source entity are matched. **Note:**  By default, not all fields are enabled for exact matching. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable a field for exact matching of similar records](#EnableFieldExactMatch) <br /><br /> Text match:   Text in these fields is used for finding key phrases to match. For example, if you select **Case Title** or **Description**, text in these fields will be matched.|  
    |Entity|Choose an entity to use in creating a text search rule to find matching records in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. The following entities are available: Activity, Case, Case Resolution, Email, Fax, Note.<br /><br /> -   Source entity, like Case and Note.<br />-   Activity and out-of-box activity entities like Email, Fax, Letter, Phone Call, and Appointment.<br />-   Any custom Activity entity related to the source entity.|  
    |Field*|Choose the  field to use in creating a text search rule to find matching target records. The following types of fields are available: Option Set, Single Line of Text, Multiple Lines of Text.<br /><br /> Two types of fields are used for similarity analysis:<br /><br /> **Structured fields**:  Used for exact match on a field to field basis. All fields except Multiple Lines of Text are available for exact match. Each field can be used only once.<br /><br /> **Text fields**: Only fields of type Text or Option Set are available. For Option Set, the  corresponding label in the language of the user is used. Text fields are used for fuzzy match in similarity analysis with keywords/key phrase extraction. Each field can be used only once.|  
  
7.  Click **Save**.  
  
8.  Click **Activate**.  
  
9. Add more mappings to create a comprehensive search of related records.  
  
<a name="EnableFieldExactMatch"></a>   
### Enable a field for exact matching of similar records  
 To enable a field for exact match, add the field in the Quick find view of the corresponding entity.  
  
1.  Go to **Settings** > **Customizations** > **Customize the System**.  
  
2.  Expand **Entities**, expand the entity that you want to enable exact matching, such as the Account entity, and then click **Views**.  
  
3.  Click **Quick Find Active Accounts**, click **More Actions**, and then click **Edit**.  
  
4.  Under Common Tasks, click **Add Find Columns**, and then select the field that you want to enable exact matching.  
  
5.  Click **OK**, and then click **Save and Close** on the Quick Find Active Accounts page.  
  
6.  Because adding a field to a view  is a customization, you must publish the customization to enable exact matching for the field. To do this, in the left navigation pane click the entity, such as Account, and then click **Publish**. To publish all customizations, click **Publish All Customizations**.  
  
## Privacy notice  
[!INCLUDE[cc_privacy_text_analytics](../includes/cc-privacy-text-analytics.md)]  
   

### See also  
 [Preview feature: Auto suggest knowledge articles](../admin/public-preview-automatically-suggest-knowledge-articles.md)

[Preview feature: Suggest similar cases for a case](../admin/public-preview-suggest-similar-cases-for-a-case.md)   
 
[Enable document suggestions](enable-document-suggestions.md)
