


# Configure the default email font

Specific font information can be configured by editing the Rich Text Editor control global default webresource configuration. 

> ![IMPORTANT]
> Changes to this file are global for your entire organization, and will affect every instance where the Rich Text Editor (RTE) control is used. This includes the RTE used in timeline rich text notes, knowledge management, and single and multi-line fields configured to use the RTE control.

Currently, email only recognizes changes in the following configuration values. This configuration will extend in future releases.

|Configuration value  |Description  |
|---------|---------|
|font_defaultLabel     |  Sets the value that is displayed on the toolbar font name selector. This is a non-functional value, see ```stickyStyle:font-family``` for setting the functional default.    |
|font_names      | A list of semi-colon (;) delimited fonts that will display in the toolbar font name selector. There is a display name followed by the fallback set of fonts which should be used. The format is:display_name/font_name,'font_name with spaces',font_name.      |
|fontSize_defaultLabel     | Sets the value that is displayed on the toolbar font size selector. This is a non-functional value, see ```stickyStyle:font-size``` for setting the functional default. |
|fontSize_sizes      | A list of semi-colon (;) delimited font sizes that will display in the toolbar font size selector. There is a display name followed by the fallback set of fonts which should be used. The format is:display_name/font_name,'font_name with spaces',font_name. |
|stickyStyle    | Functionally sets the default font and size on a wrapper around the entire contents. Values can be set for both ```font_size``` and ```font_family```. |

**Code sample**:

```
{
    "defaultSupportedProps": {
        "font_defaultLabel": "Segoe UI",
        "font_names": "Angsana New/'Angsana New', 'Leelawadee UI', Sathu, serif;Arial/Arial, Helvetica, sans-serif;Arial Black/'Arial Black', Arial, sans-serif;Calibri Light/'Calibri Light', 'Helvetica Light', sans-serif;Calibri/Calibri, Helvetica, sans-serif;Cambria/Cambria, Georgia, serif;Candara/Candara, Optima, sans-serif;Century Gothic/'Century Gothic', sans-serif;Comic Sans MS/'Comic Sans MS';Consolas/Consolas, Courier, monospace;Constantia/Constantia, 'Hoefler Text', serif;Corbel/Corbel, Skia, sans-serif;Cordia New/'Cordia New', 'Leelawadee UI', Silom, sans-serif;Courier New/'Courier New';DaunPenh/DaunPenh, 'Leelawadee UI', 'Khmer MN', sans-serif;Franklin Gothic Book/'Franklin Gothic Book', 'Avenir Next Condensed', sans-serif;Franklin Gothic Demi/'Franklin Gothic Demi', 'Avenir Next Condensed Demi Bold', sans-serif;Franklin Gothic Medium/'Franklin Gothic Medium', 'Avenir Next Condensed Medium', sans-serif;Garamond/Garamond, Georgia, serif;Gautami/Gautami, 'Nirmala UI', 'Telugu MN', sans-serif;Georgia/Georgia, serif;Impact/Impact, Charcoal, sans-serif;Iskoola Pota/'Iskoola Pota', 'Nirmala UI', 'Sinhala MN', sans-serif;Kalinga/Kalinga, 'Nirmala UI', 'Oriya MN', sans-serif;Kartika/Kartika, 'Nirmala UI', 'Malayalam MN', sans-serif;Latha/Latha, 'Nirmala UI', 'Tamil MN', sans-serif;Leelawadee UI/'Leelawadee UI', Thonburi, sans-serif;Lucida Console/'Lucida Console', Monaco, monospace;Lucida Handwriting/'Lucida Handwriting', 'Apple Chancery', cursive;Lucida Sans Unicode/'Lucida Sans Unicode';Mangal/Mangal, 'Nirmala UI', 'Devanagari Sangam MN', sans-serif;Nirmala UI/'Nirmala UI', sans-serif;Nyala/Nyala, Kefa, sans-serif;Palatino Linotype/'Palatino Linotype', 'Book Antiqua', Palatino, serif;Raavi/Raavi, 'Nirmala UI', 'Gurmukhi MN', sans-serif;Segoe UI/'Segoe UI', 'Helvetica Neue', sans-serif;Shruti/Shruti, 'Nirmala UI', 'Gujarati Sangam MN', sans-serif;Sitka Heading/'Sitka Heading', Cochin, serif;Sitka Text/'Sitka Text', Cochin, serif;Sylfaen/Sylfaen, Mshtakan, Menlo, serif;TW Cen MT/'TW Cen MT', 'Century Gothic', sans-serif;Tahoma/Tahoma, Geneva, sans-serif;Times New Roman/'Times New Roman', Times, serif;Times/Times, 'Times New Roman', serif;Trebuchet MS/'Trebuchet MS';Tunga/Tunga, 'Nirmala UI', 'Kannada MN', sans-serif;Verdana/Verdana, Geneva, sans-serif;Vrinda/Vrinda, 'Nirmala UI', 'Bangla MN', sans-serif;メイリオ/Meiryo, メイリオ, 'Hiragino Sans', sans-serif;仿宋/FangSong, 仿宋, STFangsong, serif;微軟正黑體/'Microsoft JhengHei', 微軟正黑體, 'Apple LiGothic', sans-serif;微软雅黑/'Microsoft YaHei', 微软雅黑, STHeiti, sans-serif;新宋体/NSimSun, 新宋体, SimSun, 宋体, SimSun-ExtB, 宋体-ExtB, STSong, serif;新細明體/PMingLiU, 新細明體, PMingLiU-ExtB, 新細明體-ExtB, 'Apple LiSung', serif;楷体/KaiTi, 楷体, STKaiti, serif;標楷體/DFKai-SB, 標楷體, BiauKai, serif;游ゴシック/'Yu Gothic', 游ゴシック, YuGothic, sans-serif;游明朝/'Yu Mincho', 游明朝, YuMincho, serif;隶书/SimLi, 隶书, 'Baoli SC', serif;黑体/SimHei, 黑体, STHeiti, sans-serif;굴림/Gulim, 굴림, 'Nanum Gothic', sans-serif;궁서/Gungsuh, 궁서, GungSeo, serif;돋움/Dotum, 돋움, AppleGothic, sans-serif;맑은 고딕/'Malgun Gothic', '맑은 고딕', AppleGothic, sans-serif;바탕/Batang, 바탕, AppleMyungjo, serif;바탕체/BatangChe, 바탕체, AppleMyungjo, serif;ＭＳ Ｐゴシック/'MS PGothic', 'ＭＳ Ｐゴシック', 'MS Gothic', 'ＭＳ ゴシック', 'Hiragino Kaku Gothic ProN', sans-serif;ＭＳ Ｐ明朝/'MS PMincho', 'ＭＳ Ｐ明朝', 'MS Mincho', 'ＭＳ 明朝', 'Hiragino Mincho ProN', serif",
        "fontSize_defaultLabel": "9",
        "fontSize_sizes": "8/8pt;9/9pt;10/10pt;11/11pt;12/12pt;14/14pt;16/16pt;18/18pt;20/20pt;22/22pt;24/24pt;26/26pt;28/28pt;36/36pt;48/48pt;72/72pt;",
        "stickyStyle": {
            "font-size": "9pt",
            "font-family": "'Segoe UI','Helvetica Neue',sans-serif"
        }
    }
}
```

## Sample email configurations

The following sample email configuration code sample data can be used to enable specific fonts by editing the rich text editor control global default webresource configuration.

> ![IMPORTANT]
> Changes to this file are global for your entire organization and will affect every instance where the Rich Text Editor (RTE) control is used. This includes the RTE used in timeline rich text notes, knowledge management, and single and multi-line fields configured to use the RTE control.

Add a new font list and set "Brush Script MT" as the default font with a default size of 20 pt.

The following code sample shows only the names and values to edit:

```
{
    "defaultSupportedProps": {
        "font_defaultLabel": "Brush Script MT",
        "font_names": "Brush Script MT/'Brush Script MT', cursive;Calibri/Calibri, Helvetica,sans-serif;Calibri Light/'Calibri Light', 'Helvetica Light', sans-serif;",
        "fontSize_defaultLabel": "20",
        "fontSize_sizes": "8/8px;12/12px;20/20px;32/32px;",
        "stickyStyle": {
            "font-size": "20px",
            "font-family": "'Brush Script MT', cursive"
        }
    }
}
```


### See also

[Configure email](https://go.microsoft.com/fwlink/p/?linkid=2142941)<br>
[Create an email template](customer-service-hub-user-guide-email-create-template.md)<br>
[Insert an email template](customer-service-hub-user-guide-email-insert-template.md)<br>
[Convert an email to a template](customer-service-hub-user-guide-email-convert-template.md)<br>
[Attach a file to email](customer-service-hub-user-guide-email-attachments.md)<br>
[Use a signature in email](customer-service-hub-user-guide-email-create-signature.md)<br>
[Email FAQs](email-faqs.md)  
