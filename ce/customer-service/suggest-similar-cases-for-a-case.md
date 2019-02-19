---
title: Suggest similar cases for a case with Dynamics 365 for Customer Engagement| MicrosoftDocs
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
# Use advanced similarity rules to view similar case suggestions

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Quickly support your customers by viewing similar cases suggestions in the Customer Service Hub. As an administrator, you can now configure criteria using advanced similarity rules, so that agents can view cases similar to their current case and resolve customer issues in first contact and within minimal time frame. This helps to reduce operational cost and in turn increase customer satisfaction.

If an agent is working on a support case, they can view similar cases in the **Related** section of the current case, and resolve their case quickly. With the help of Relevance search, they can use keywords or key phrases in a service case to quickly find related cases and use them to resolve customer issues. 
  
## Similar case suggestion scenario

Gilda is resolving an issue where a customer is not able to book a travel package on the portal. To assist the customer quickly, she seeks guidance by looking for similar cases in the **Similar cases** tab in the **Related** section of the current case.

Based on configured data input, the Relevance search mechanism filters the cases using key phrases and suggests a list of cases that Gilda can refer. She selects a relevant case and glances through the details. She is able to resolve the customer issue with this suggested case. She can also link the case to the current case for future reference. 

## Create a new similar case suggestion rule
 Set up automatic suggestion of similar cases by creating advanced similarity rules. The rules you create use the Relevance search mechanism.

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Relevance Search for faster, comprehensive search results](../basics/relevance-search-results.md)

> [!IMPORTANT]
> It is recommended to enable Relevance search for the most accurate suggestions for similar cases. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure Relevance Search to improve search results and performance](../admin/configure-relevance-search-organization.md)


1.  Make sure you have the Sales or Marketing Manager, Customer Service Manager, System Administrator, or System Customizer security role or equivalent permissions.  
  
    #### Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  


2. In the Customer Service Hub sitemap, go to **Service Management** > **Advanced Similarity Rules**.

   The **Advanced Similarity Rules** page is displayed.

2. Select **New** from the command bar to create a new advanced similarity rule.  

3. In the **Details** tab:
   - Fill in the fields in the new advanced similarity rule dialog box:


     |                   Item                   |                                                                                                                                                                                                      Description                                                                                                                                                                                                      |
     |------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
     |             Name (required)              |                                                                                                                                                                                             The name of the rule.                                                                                                                                                                                              |
     |         Source Entity (required)         |                                                                                                Select Case entity for similar cases suggestions.                                                                                                |
     |               Description                |                                                                                                                                                                                         A description of the similarity rule.                                                                                                                                                                                         |
     |Noise Key phrases|Provide noise key phrases separated by a semicolon ( ; ). These phrases will be filtered while searching for a similar case| 
      |         Filter Result by Status          |                                                                                                                                          Filter records by status                                                                                                                                          |
     |||
    - Select **Save** to save the rule.
  

      ![similar case configuration](media/similar-case-config.PNG)

  4. In the **Match Fields** tab:

     - Select **Add New Text Analytics Entity Mapping** to add a new related text analytics entity mapping record to this rule.
     - Fill in the details in the **Details** tab in the new record. These values are used to determine the keywords or key phrases from source records using relevance search to match with target records using text search. This helps to achieve keyword-based similarity between source and target records.  


       |   Item   |                                                                                                                                                                                                                                                                                                                                                                            Description                                                                                                                                                                                                                                                                                                                                                                             |
       |----------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
       | Criteria |                                                                                                                                      **Exact match**: Only fields from the source entity are matched. **Note:**  By default, not all fields are enabled for exact matching. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable a field for exact matching of similar records](#enable-a-field-for-exact-matching-of-similar-cases) <br /><br /> **Text match**:   Text in these fields is used for finding key phrases to match. For example, if you select **Case Title** or **Description**, text in these fields will be matched.                                                                                                                                       |
       |  Entity (required)  |                                                                                                                                               Choose an entity from the drop-down list to be used to create a text search rule to find matching records in [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps.                                                                                                                                              |
       | Field (required) | Choose the  field to be used to create a text search rule to find matching target records. <br /><br /> Two types of fields are used for similarity analysis:<br /><br /> **Structured fields**:  Used for exact match on a field to field basis. All fields except Multiple Lines of Text are available for exact match. Each field can be used only once.<br /><br /> **Text fields**: Only fields of type Text or Option Set are available. For Option Set, the  corresponding label in the language of the user is used. Text fields are used for fuzzy match in similarity analysis with keywords/key phrase extraction. Each field can be used only once. |
       |||

       ![similar-case-rule](media/similar-case-rule.PNG)

5. Select **Save** to save the rule.

6. Select **Activate** from the command bar to activate the rule.

Similarly, add more mappings to view a comprehensive search of related records.

### Enable a field for exact matching of similar cases  
 To enable a field for exact match, add the field in the Quick find view of the corresponding entity.  

1.  Go to **Settings** > **Customizations** > **Customize the System**.  

2.  Expand **Entities**, expand the entity that you want to enable exact matching, Case entity in this scenario, and then select **Views**.  

3.  Select **Quick Find Active Accounts**, select **More Actions**, and then select **Edit**.  

4.  Under **Common Tasks**, select **Add Find Columns**, and then select the field that you want to enable for exact matching.  

5.  Select **OK**, and then select **Save and Close** on the **Quick Find Active Accounts** page.  

As adding a field to a view is a form of customization, you must publish this customization to enable exact matching for the field. To do this, in the left navigation pane select the entity, Case entity in this scenario, and then select **Publish**. To publish all customizations, select **Publish All Customizations**.
  
## See similar case suggestions in the Customer Service Hub

You can view the similar case suggestions in the Related section of the Customer Service Hub. 

[!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [See and manage related records in the Related section](customer-service-hub-user-guide-case-sla.md#see-and-manage-related-records-in-the-related-section)
  
1. In the Customer Service Hub, navigate to **Service** > **Cases** and open a case from the **My Active Cases** view.
  
2. Select the **Similar Cases** in the **Related** section to view cases similar to the current case.  
  
   ![View similar cases](media/view-similar-cases.png)
  
### See also  

[Related section in the Customer Service Hub](customer-service-hub-user-guide-basics.md#related-section)

[Service Management Guide (Customer Service Hub and Customer Service app)](service-manager-guide.md)