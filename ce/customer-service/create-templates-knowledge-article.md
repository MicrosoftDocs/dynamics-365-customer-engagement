---
title: "Create templates for knowledge article for Dynamics 365 Customer Service | MicrosoftDocs"
author: udaykirang
ms.author: udag
manager: shujoshi
ms.date: 07/31/2019
ms.topic: article
ms.service: crm-online
ms.assetid: b47eec74-e83c-4cfe-b7a0-a9195a3ac4da
search.audienceType: admin
caps.latest.revision: 35
---

# Create knowledge article template

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../legal/dynamics-insider-agreement.md).

Knowledge article templates help knowledge authors by simplifying the process of creating knowledge articles. Templates also help knowledge managers and authors in maintaining consistency in branding, language, and structure. 

When an author chooses a template to create an article, the fields that are defined in the template are prepopulated, allowing the author to focus on the main content of the article.

> [!NOTE]
> To learn how to use knowledge article templates to create knowledge articles, see [Create knowledge articles using templates](customer-service-hub-user-guide-knowledge-article.md#create-knowledge-articles-using-templates)

As a Knowledge Manager, you can create knowledge article templates by defining the necessary fields such as Language, Title, Keywords, and Subject. These fields will be pre-populated while creating the article using the template and reduce the efforts of authors to fill in these fields. 

> [!NOTE]
> Make sure you have the required privileges to create, edit, or delete knowledge article templates. Contact your administrator if you do not have these privileges.

1.	Open **Customer Service Hub** app and select **Change area > Service Management**.

    > [!div class=mx-imgBorder]
    > ![Select service management](media/ka-select-service-management.png "Select service management")

2.	Under **Knowledge Base Management** section, select **Article Templates**.

    > [!div class=mx-imgBorder]
    > ![Select article templates](media/ka-select-article-template.png "Select article templates")

3.	To create a template, select **+ New**.

    > [!div class=mx-imgBorder]
    > ![Select new](media/ka-select-new.png "Select new")
 
4.	On the **Choose Language** dialog box, select the language for the template, and select **OK**. In this example, we are selecting the language as **English – United States**.

    > [!div class=mx-imgBorder]
    > ![Choose language](media/ka-choose-language.png "Choose language")
 
5.	On the **New Knowledge Article Template** page, enter the values for the required fields that you want to prepopulate when the template is selected.

    |Section|Field|Description|
    |-------|-----|-----------|
    | **TEMPLATE DATA** | Name | Enter a name for the template. |
    || Owner | Enter the name of the owner who owns the template. By default, your name will be displayed in this field. | 
    | **ARTICLE DATA** | `--` | Define article fields such as Title, Keywords, and Subject which are used in any knowledge article that’s created based on the template. |
    | **CONTENT** | `--` | Define a structure that will be used in any knowledge article that’s created based on this template. To learn more, see [Use the rich text editor to create knowledge articles and emails.](customer-service-hub-user-guide-knowledge-article.md#use-the-rich-text-editor-to-create-knowledge-articles-and-emails) |

    > [!div class=mx-imgBorder]
    > ![Enter the values in new knowledge article template](media/ka-new-template-page.png "Enter the values in new knowledge article template")

6.	After you have entered the required information, select **Save**.

    A template is created and is available for knowledge authors to use to create articles.

> [!NOTE]
> Similarly, you can edit or delete knowledge article templates from the **Service Management** area. 


### See also

[Create knowledge articles using templates](customer-service-hub-user-guide-knowledge-article.md#create-knowledge-articles-using-templates)
