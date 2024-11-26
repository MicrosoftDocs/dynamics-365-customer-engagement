---
title: Configure the faceted search results web template from your portal
description: Know how the faceted search results web template can be configured from your portal.
ms.date: 07/31/2024
ms.topic: article
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
search.audienceType:
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - bap template
---

# Configure the faceted search results web template from your portal

You can view and search for knowledge article attachments on the portal based on Dataverse search. To do so, you must configure the faceted search results web template from your portal.

1. In the site map of Portal Management, go to **Content** area and select **Web Templates**. You can sign in to Portal Management from multiple locations. Learn more in [Portal Management app overview](/power-pages/configure/portal-management-app).
1. From the **Active Web Templates** dropdown list, select your knowledge article web template.
1. On the **Web Template** page, select the **General** tab, add the following snippet to the **Source** field.

  
  ```JavaScript                        
                              {{#if relatedAttachments}}
								{{#each relatedAttachments}}
									<li class="note-item">
									{{#if isImage}}
										<a id="kbattachment-{{entityID}}" href="javascript:downloadKbAttachmentFile('kbattachment-{{entityID}}', '{{title}}', {{fileSize}}, '{{fileType}}', '{{downloadBlockUrl}}', '{{initializeDownloadUrl}}')"><span class="glyphicon glyphicon-file" aria-hidden="true"></span>&nbsp;{{title}}</a>
									{{else}}
										<a id="kbattachment-{{entityID}}" title="{{title}}" href="javascript:downloadKbAttachmentFile('kbattachment-{{entityID}}', '{{title}}', {{fileSize}}, '{{fileType}}', '{{downloadBlockUrl}}', '{{initializeDownloadUrl}}')"><span class="glyphicon glyphicon-file" aria-hidden="true"></span>&nbsp;{{title}}</a>
									{{/if}}
									<p class="fragment text-muted">{{{fragment}}}</p>
									</li>
								{{/each}}
							{{/if}}
<script type="text/javascript">
		function downloadKbAttachmentFile(attachmentElementId, fileName, fileSize, mimeType, downloadBlockUrl, initializeUrl) {
					// Download block API supports max 4MB block size
					const blockSizeInBytes = 4096 * 1024;
					const totalNumberOfBlocks = parseInt(fileSize / blockSizeInBytes + 1);
					var fileContinuationToken = "";
					var contentString = "";
					var numberOfBlocksDownloaded = 0;
					var blockNumberToContentMap = {};
					function downloadBlockCallback(i, result) {
						numberOfBlocksDownloaded++;
						blockNumberToContentMap[i] = result;
						if (numberOfBlocksDownloaded == totalNumberOfBlocks) {
							for (var j = 0; j < totalNumberOfBlocks; j++) {
								contentString += blockNumberToContentMap[j];
							}
							var isImage = mimeType.startsWith('image/');
							const attachmentElement = document.getElementById(attachmentElementId);
							if (isImage) {
								const bodyByteString = atob(contentString);
								const bodyBuffer = new ArrayBuffer(bodyByteString.length);
								const bodyView = new Uint8Array(bodyBuffer);
								for (var k = 0; k < bodyByteString.length; k++) {
									bodyView[k] = bodyByteString.charCodeAt(k);
								}
								var imageUrl = URL.createObjectURL(new Blob([bodyBuffer], { type: mimeType }));
								attachmentElement.href = imageUrl;
								attachmentElement.target = "_blank";
							}
							else {
								const linkSource = 'data:' + mimeType + ';base64,' + contentString;
								attachmentElement.href = linkSource;
								attachmentElement.download = fileName;
							}
							attachmentElement.click();
						}
					}
					shell.ajaxSafePost({
						type: 'GET',
						url: initializeUrl,
						success: function (result) {
							fileContinuationToken = encodeURIComponent(result);
							for (var i = 0; i < totalNumberOfBlocks; i++) {
								url = downloadBlockUrl + "&blockNumber=" + i + "&fileContinuationToken=" + fileContinuationToken + "&blockSize=" + blockSizeInBytes;
								var x = downloadBlockCallback.bind(this,i);
								shell.ajaxSafePost({
									type: 'GET',
									url: url,
									success: (result) => { x(result) }
								});
							}
						}
					});
				}
		</script>
```

4. Select **Save**.

### Related information

[Add a file attachment to a knowledge article](../use/customer-service-hub-user-guide-knowledge-article.md#add-a-file-attachment-to-a-knowledge-article)  
[Update knowledge article attachments for portal](../administer/set-up-knowledge-management-embedded-knowledge-search.md#update-knowledge-article-attachments-for-portal)  
[Display file attachments with knowledge articles](/powerapps/maker/portals/customer-engagement-apps/display-file-attachments-knowledge-article)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
