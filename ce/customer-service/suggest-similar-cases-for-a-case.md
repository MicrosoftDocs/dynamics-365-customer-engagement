---
title: Suggest similar records for a record with Dynamics 365 for Customer Engagement| MicrosoftDocs
ms.date: 12/21/2018
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 91e10e68-8edf-4eee-a69e-9d9b6fac16f9
author: anjgupta
ms.author: anjgup
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---
# Suggest similar records using advanced similarity rules

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Quickly support your customers by viewing similar record suggestions in the Customer Service Hub. With the help of advanced similarity rules, you can now view records similar to your current record and resolve customer issues in the first contact and within minimal time. This helps in increased customer satisfaction (CSAT) and reduced operational cost. 

For example, if you're working on a support case, you can view similar cases in the Related section, and resolve your current case quickly. With the help of Relevance search, you can leverage keywords or key phrases in a service case to quickly find related cases and use them to resolve your current case. 
  
[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Relevance Search to improve search results and performance](../admin/configure-relevance-search-organization.md)

## Create a new similar record suggestion rule
 Set up automatic suggestion of similar records by creating rules. The rules you create use Relevance search mechanism.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Relevance Search for faster, comprehensive search results](../basics/relevance-search-results.md)

> [!NOTE]
> You can create only one similar records suggestions rule for each entity type.  

1. In the Customer Service Hub sitemap, go to **Service Management** > **Advanced Similarity Rules**.  

   The **Advanced Similarity Rules** page is disolayed.

2. Select **New** from the command bar to create a new advanced similarity rule.  

3. In the **Details** tab:
   - Fill in the fields in the new advanced similarity rule dialog:


     |                   Item                   |                                                                                                                                                                                                      Description                                                                                                                                                                                                      |
     |------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
     |             Name (required)              |                                                                                                                                                                                             The name of the rule.                                                                                                                                                                                              |
     |         Source Entity (required)         |                                                                                                The entity for which similar records are suggested.  Select either Account, Case, Contact, Lead, Opportunity, or a custom entity that has an N:N relationship with one of the entities supported for similarity rules.                                                                                                 |
     |               Description                |                                                                                                                                                                                         A description of the similarity rule.                                                                                                                                                                                         |
     |Noise Keyphrases||
      |         Filter Result by Status          |                                                                                                                                          Filter records by status                                                                                                                                          |

    - Select **Save** to save the rule.

  4. In the **Match Fields** tab:

     - Select **Add New Text Analytics Entity Mapping** to add a new related text analytics entity mapping record to this rule.
     - Fill in the details in the **Details** tab in the new record. These values are used to determine the keywords or key phrases from source records using relevance search to match with target records using text search. This helps to achieve keyword-based similarity between source and target records.  


       |   Item   |                                                                                                                                                                                                                                                                                                                                                                            Description                                                                                                                                                                                                                                                                                                                                                                             |
       |----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
       | Criteria |                                                                                                                                      **Exact match**: only fields from the source entity are matched. **Note:**  By default, not all fields are enabled for exact matching. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable a field for exact matching of similar records](#EnableFieldExactMatch) <br /><br /> **Text match**:   Text in these fields is used for finding key phrases to match. For example, if you select **Case Title** or **Description**, text in these fields will be matched.                                                                                                                                       |
       |  Entity (required)  |                                                                                                                                               Choose an entity from the drop-down list to be used to create a text search rule to find matching records in [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps.                                                                                                                                              |
       | Field (required) | Choose the  field to be used to create a text search rule to find matching target records. The following types of fields are available: Option Set, Single Line of Text, Multiple Lines of Text.<br /><br /> Two types of fields are used for similarity analysis:<br /><br /> **Structured fields**:  Used for exact match on a field to field basis. All fields except Multiple Lines of Text are available for exact match. Each field can be used only once.<br /><br /> **Text fields**: Only fields of type Text or Option Set are available. For Option Set, the  corresponding label in the language of the user is used. Text fields are used for fuzzy match in similarity analysis with keywords/key phrase extraction. Each field can be used only once. |


5. Select **Save** to save the rule.

6. Select **Activate** from the command bar to activate the rule.

Similarly, add more mappings to create a comprehensive search of related records.

### Enable a field for exact matching of similar records  
 To enable a field for exact match, add the field in the Quick find view of the corresponding entity.  

1.  Go to **Settings** > **Customizations** > **Customize the System**.  

2.  Expand **Entities**, expand the entity that you want to enable exact matching, such as the Account entity, and then click **Views**.  

3.  Click **Quick Find Active Accounts**, click **More Actions**, and then click **Edit**.  

4.  Under Common Tasks, click **Add Find Columns**, and then select the field that you want to enable exact matching.  

5.  Click **OK**, and then click **Save and Close** on the Quick Find Active Accounts page.  

6.  Because adding a field to a view  is a customization, you must publish the customization to enable exact matching for the field. To do this, in the left navigation pane click the entity, such as Account, and then click **Publish**. To publish all customizations, click **Publish All Customizations**.  
  
## See related records in the Customer Service Hub

You can view the similar record suggestions in the Related section of the Customer Service Hub. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See and manage related records in the Related section](customer-service-hub-user-guide-case-sla.md#see-and-manage-related-records-in-the-related-section)
  
1. In the Customer Service Hub, navigate to **Service** > **Cases** and open a case from the **My Active Cases** view.
  
2. Select the **Similar Cases** button in the **Related** section to view cases similar to the current case.  
  
   ![View similar cases](media/view-similar-cases.png)
  
### See also  

[Service Management Guide (Customer Service Hub and Customer Service app)](service-manager-guide.md)