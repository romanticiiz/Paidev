<%@ Page Language="C#" MasterPageFile="~/Master/PaidevMaster01.Master" AutoEventWireup="true" CodeBehind="TimePickerTest01.aspx.cs" Inherits="Paidev.Web.TimePicker.TimePickerTest01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpHead" runat="server">
    <script type="text/javascript">
        // 캘린더로드
        $(document).ready(function () {
            var sday = '<%=Sdays %>';
            var eday = '<%=Edays %>';

            $.datepicker.regional['ko'] = {
                monthNames: ['01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12'],
                monthNamesShort: ['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12'],
                dateFormat: 'yy-mm-dd',
                showMonthAfterYear: true,
                yearSuffix: ' -',
                showButtonPanel: true
            };
            $.datepicker.setDefaults($.datepicker.regional['ko']);

            if (sday != "") {
                $(".calendar:eq(0)").datepicker().datepicker('setDate', sday);
                $(".calendar:eq(1)").datepicker().datepicker('setDate', eday);
            }
            else {
                $(".calendar").datepicker().datepicker('setDate', new Date());
            }

            $('div.ui-datepicker').css('font-size', '14px');

            // 타임박스로드
            $('.time').timepicker({
                showAnim: 'blind'
            }).timepicker('setTime', new Date());

            // 확인버튼
            $('.btnArea button').on('click', function () {
                if (CheckSubmit())
                    alert('선택한시작날짜: ' + document.getElementById('<%=hFromDate.ClientID %>').value + '\n선택한종료날짜: ' + document.getElementById('<%=hToDate.ClientID %>').value);
            });
        });

    function CheckSubmit() {
        if (document.forms[0].FromDate.value == '') { alert('시작일을 선택해 주세요'); return false; }
        if (document.forms[0].FromTime.value == '') { alert('시작시간을 선택해 주세요'); return false; }
        if (document.forms[0].ToDate.value == '') { alert('종료일을 선택해 주세요'); return false; }
        if (document.forms[0].ToTime.value == '') { alert('종료시간을 선택해 주세요'); return false; }

        var fromdate = document.forms[0].FromDate.value;
        var fromtime = document.forms[0].FromTime.value;
        var todate = document.forms[0].ToDate.value;
        var totime = document.forms[0].ToTime.value;

        var start = $(".calendar:eq(0)").datepicker('getDate');
        var end = $(".calendar:eq(1)").datepicker('getDate');

        if (start > end)
        { alert("시작일은 종료일 보다 클 수 없습니다."); return false; }

        document.getElementById('<%=hFromDate.ClientID %>').value = fromdate + " " + fromtime;
            document.getElementById('<%=hToDate.ClientID %>').value = todate + " " + totime;

            return true;
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContents" runat="server">
    <div id="container">
        <table class="proposal" cellspacint="0" cellpadding="0">
          <tr>
            <td>
                <div class="period">
                    시작일시: <input class="form calendar" readonly type="text" size="10" name="FromDate" />&nbsp;
                    <input class="form time" readonly type="text" style="width: 70px;" id="FromTime" />&nbsp;&nbsp;
                    종료일시 : &nbsp;<input class="form calendar" readonly type="text" size="10" name="ToDate" />&nbsp;
                    <input class="form time" readonly type="text" style="width: 70px;" id="ToTime" />
                </div>
            </td>
          </tr>
        </table>
    </div>
    <div class="btnArea clearFix">
        <p class="btn btnL">
            <button type="button" id="btnRefresh" runat="server">확인</button>            
        </p>        
    </div>
    <asp:HiddenField ID="hFromDate" runat="server" EnableViewState="false" />
    <asp:HiddenField ID="hToDate" runat="server" EnableViewState="false" />                    
</asp:Content>