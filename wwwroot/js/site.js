$(document).ready(function(){
    $('#Stud_Name').on('input', function () {
        var name = $(this).val();
        if (name == "") {
            $('#S_name').text('Please enter your name');
            $('#check').val('Invalid');

        } else if (name.length < 3) {
            $('#S_name').text('Name should contain atleast three characters');
            $('#check').val('Invalid');
        } else {
            $('#S_name').empty();

        }
    });
        $('#Contact').on('input', function () {
            var contact = $(this).val();
            var contact_tmp = contact.trim().split(' ').join('');
            var count = 10;
            if (contact_tmp.length !== count || isNaN(contact_tmp)) {
                $('#S_cont').text('Invalid Contact Number, Enter Numbers only!');
                $('#check').val('Invalid');
            }
                else {
                    $('#S_cont').empty();
                }
        });
    });
