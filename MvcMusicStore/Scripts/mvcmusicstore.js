//my very own js File
$(function () {
    $(".lead").hover(function () {
        $(this).animate({ height: '+=25', width: '+=25' })
               .animate({ height: '+=25', width: '+=25' });
    });
});