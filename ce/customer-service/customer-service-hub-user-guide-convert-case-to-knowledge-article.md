---
title: "Convert a case to a knowledge article in Customer Service Hub | MicrosoftDocs"
description: "Perform the steps mentioned in the topic to convert a case to a Knowledge article in Customer Service Hub for Dynamics 365 Customer Service."
ms.date: 12/14/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
searchScope:
- D365-App-customerservicehub
- D365-Entity-incident
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Convert a case to a Knowledge article

There are times when existing knowledge articles don't contain relevant information for resolving a case. You, as an agent, can now contribute to the knowledge base by turning all information that's been researched for a case into a knowledge article. You can convert one case into multiple knowledge articles.  


1. Make sure you have Create permissions on the Knowledge Article entity.  

2. In the list of active cases, open the one that has the information that you want to convert to a knowledge article.  

3. On the command bar, select the ellipsis **(...)** and go to **Convert To** > **To Knowledge Article**.  

    The **Convert to Knowledge Article** dialog box opens. The title, owner, and subject of the article are populated based on the title, owner, and subject of the case. The content of the article is automatically populated with the description of the case. If the case is resolved, the content field shows the case description, case resolution, and case resolution description.  

4. If you want to open the newly-created article, select the **Open the new knowledge article** field to set it to **Yes**, and then select **Convert**. Otherwise, set it to **No**.  

5. If you set **Open the new knowledge article** to **Yes**, a knowledge article form opens. Fill in the necessary information for the knowledge article, and then select the **Save** button. More information: [Create and manage knowledge articles](customer-service-hub-user-guide-knowledge-article.md#create-and-manage-knowledge-articles)

The knowledge article is created regardless of whether you set **Open the new knowledge article** to **Yes** or **No**.  

### See also

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
