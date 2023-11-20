$(document).ready(function () {
    $('ul.tab li  a ').click(function () {
       // alert("Butona Tıklandı");

       //removeClass() metodu belirtilen elementin içerisindeki class bilgisini silmek için kullanılır
        $('ul.tab li a ').removeClass('active');

        //addClass() metodu belirtilen elementin içerisine belirtilen class bilgisini eklemek için kullanılır
        $(this).addClass('active');

        var dataShow = $(this).data('show');

        $('div.tabIcerik > div').slideUp();
        $(dataShow).slideDown();

    });



});