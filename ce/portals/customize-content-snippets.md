# Customize content by using content snippets

Applies To: Dynamics 365 (online), Dynamics CRM Online

Content snippets are small chunks of editable content that can be placed by a developer on a page template, allowing for customizable content to populate any portion of a page's layout easily. Snippet controls, which are responsible for rendering the content of snippets on the web-facing portal, are placed on .aspx pages by developers. For information on how to develop with snippets, see the developer's guide.

## Edit snippets

Snippets can be edited either through the front-side or through the Dynamics 365 interface. The main power of the snippet is the fact that you can abstract a bit of content (other than the main copy of the page) and edit it separately, allowing essentially any static content on your site to be fully content-managed and front-side editable but still backed by Dynamics 365.

## Edit using the front-side editing engine

To edit snippets on the front side, users must be associated with a Web Role that is associated with a Website Access Permission record with the **Manage Content Snippets** permission set to true.

To edit through the front side, hover over the snippet element and click the edit button. You must have website access permissions to edit snippets. More information: [Control webpage access for portals](webpage-access-control.md)  

When editing a snippet, either a simple text box will appear, allowing you to quickly edit the content, or the full editor appears, as it does when editing a page's copy.

Which of these two interfaces appears is determined by the edit type of the snippet, which also determines the type of content the snippet can hold (full, stylized HTML content versus plain text). A snippet can be assigned an edit type of either text or HTML when a developer adds the Content Snippet control to the page template in the Portal's Visual Studio project.

## Edit by using Dynamics 365

1.  Navigate to **Portals** -&gt; **Content Snippets**

<!-- -->

1.  To create a new snippet: Click **New**

2.  To edit an existing snippet: Double-Click on an existing **Content Snippet** in the grid

Enter values for the following fields:

| Name    | Description                                                                                                   |
|---------|---------------------------------------------------------------------------------------------------------------|
| Name    | The name can be used by a developer to place the snippet value into a page template within the portal's code. |
| Website | The website that is associated with the snippet.                                                              |
| Value   | The content of the snippet to be displayed in the portal. This can contain plain text or HTML markup.         |

### See Also

[How to provision a portal](provision-portal.md)  
[Get started with the portal content editor](get-started-portal-content-editor.md)  
[Use the front-side editing engine to publish content](publish-content-editing-engine.md)  
[Add dynamic content and create custom templates](custom-templates-dynamic-content.md)  

