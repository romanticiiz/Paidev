<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="smarteditor.aspx.cs" Inherits="Paidev.Web.Etc.smarteditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="ko" xml:lang="ko">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>    
</head>
<script type="text/javascript" src="/se2/js/HuskyEZCreator.js" charset="utf-8"></script>
<script type="text/javascript" src="/se2/photo_uploader/plugin/hp_SE2M_AttachQuickPhoto.js" charset="utf-8"></script>
<body>
    <form id="form1" runat="server">
    <div>
        <textarea name="ir1" id="ir1" rows="10" cols="100">에디터에 기본으로 삽입할 글(수정 모드)이 없다면 이 value 값을 지정하지 않으시면 됩니다.</textarea>
        <button type="button" onclick="submitContents();">확인</button>
    </div>
    </form>
    <script type="text/javascript">
        var oEditors = [];
        nhn.husky.EZCreator.createInIFrame({
            oAppRef: oEditors,
            elPlaceHolder: "ir1",
            sSkinURI: "/se2/SmartEditor2Skin.html",
            fCreator: "createSEditor2"
        });

        function submitContents(elClickedObj) {
            // 에디터의 내용이 textarea에 적용됩니다.
            oEditors.getById["ir1"].exec("UPDATE_CONTENTS_FIELD", []);

            // 에디터의 내용에 대한 값 검증은 이곳에서
            // document.getElementById("ir1").value를 이용해서 처리하면 됩니다.

            alert(document.getElementById("ir1").value);

            try {
                elClickedObj.form.submit();
            } catch (e) { }
        }
    </script>
</body>    
</html>
