$(function() {

    $("#form-entry").validate({
        rules: {
            password: "required"
        },


        messages: {
            password: {
                required: "Введите пароль"
            }
        }
    });

    $("#form-registration").validate({
        rules: {
            txtUserName: "required",
            password: "required",
            confirmPassword: {
                required: true,
                equalTo: "#password"
            },
            txtQuestion: "required",
            txtAnswer: "required"
        },


        messages: {
            txtUserName: {
                required: "Введите имя"
            },
            password: {
                required: "Введите пароль"
            },
            confirmPassword: {
                required: "Подтвердите пароль",
                equalTo: "Пароли не совпадают"
            },
            txtQuestion: {
                required: "Введите контрольный вопрос"
            },
            txtAnswer: {
                required: "Введите ответ"
            }
        }

    });

    $("#form-addCost").validate({
        rules: {
            txtCommentForCost: "required",
            txtSummofCost: "required"
        },


        messages: {
            txtCommentForCost: {
                required: "Введите комментарий"
            },
            txtSummofCost: {
                required: "Введите сумму"
            }
        }

    });

    $("#form-addIncome").validate({
        rules: {
            txtCommentForIncome: "required",
            txtSummofIncome: "required"
        },


        messages: {
            txtCommentForIncome: {
                required: "Введите комментарий"
            },
            txtSummofIncome: {
                required: "Введите сумму"
            }
        }

    });

    $("#form-addDebt").validate({
        rules: {
            txtNameForDebt: "required",
            txtSummofDebt: "required"
        },


        messages: {
            txtNameForDebt: {
                required: "Введите имя"
            },
            txtSummofDebt: {
                required: "Введите сумму"
            }
        }

    });

    $("#form-addAccumulation").validate({
        rules: {
            txtAccumulationName: "required",
            txtSummofAccumulation: "required"
        },


        messages: {
            txtAccumulationName: {
                required: "Введите наименование"
            },
            txtSummofAccumulation: {
                required: "Введите сумму"
            }
        }

    });

});