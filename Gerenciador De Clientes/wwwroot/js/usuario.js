document.addEventListener("DOMContentLoaded", function (event) {
    const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
    const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))

    $('#inscricaoEstadual').on('input', function () {
        mascaraInscricaoEstadual(this);
    });

    $('#telefone').on('input', function () {
        mascaraTelefone(this);
        console.log("Entrei")
    });

    EsconderTodos();
    mudancaTipo();

    mostrarIscricaoEstadualPessoaFisica();
    desabilitaIscricaoEstadual();

    $("form").submit(function (event) {
        if (!validarSenha()) {
            event.preventDefault();
        }
    });
});

function mascaraTelefone(input) {
    var v = input.value;

    if (isNaN(v[v.length - 1])) {
        input.value = v.substring(0, v.length - 1);
        return;
    }
    input.setAttribute("maxlength", "15");
    if (v.length == 1) input.value = "(" + input.value;
    if (v.length == 3) input.value += ") ";
    if (v.length == 10 ) input.value += "-";
}

function mascaraCpf(input) {
    var v = input.value;

    if (isNaN(v[v.length - 1])) {
        input.value = v.substring(0, v.length - 1);
        return;
    }

    input.setAttribute("maxlength", "14");
    if (v.length == 3 || v.length == 7) input.value += ".";
    if (v.length == 11) input.value += "-";
}

function mascaraCNPJ(input) {
    var v = input.value;

    if (isNaN(v[v.length - 1])) {
        input.value = v.substring(0, v.length - 1);
        return;
    }

    input.setAttribute("maxlength", "18");
    if (v.length == 2 || v.length == 6) input.value += ".";
    if (v.length == 10) input.value += "/";
    if (v.length == 15) input.value += "-";
}

function mascaraInscricaoEstadual(input) {

    var v = input.value;

    if (isNaN(v[v.length - 1])) {
        input.value = v.substring(0, v.length - 1);
        return;
    }

    input.setAttribute("maxlength", "15");
    if (v.length == 3 || v.length == 7) input.value += ".";
    if (v.length == 11) input.value += "-";
}

function mudancaTipo() {
    $('#tipo').on('change', function () {
        const selectedOption = $(this).val();

        if (selectedOption === '1') {           
            mostrarCamposPessoaFisica();
            defineCamposObrigatoriosPessoaFisica(true)
        }
        else if (selectedOption === '0') {
            mostrarCamposPessoaJuridica();
            defineCamposObrigatoriosPessoaFisica(false)
        }
        else {
            $('label[for="nomeRazaoSocial"]').text('Nome/Razão Social:');

            EsconderTodos();
        }
    });
};

function mostrarCamposPessoaFisica() {
    $('label[for="nomeRazaoSocial"]').text('Nome:');
    $('label[for="cpfCnpj"]').text('CPF:');

    $('#cpfCnpj').on('input', function () {
        mascaraCpf(this);
    });

    $('#cpfCnpj').val('');

    mostraCampo("cpfCnpj");
    mostraCampo("form-check-inscricaoEstadualPessoaFisica");
    mostraCampo("genero");
    mostraCampo("dataNascimento");
    escondeCampo("form-check-isento");
    escondeCampo("inscricaoEstadual");
}

function mostrarCamposPessoaJuridica() {
    $('label[for="nomeRazaoSocial"]').text('Razão Social:');
    $('label[for="cpfCnpj"]').text('CNPJ:');

    $('#cpfCnpj').on('input', function () {
        mascaraCNPJ(this);
    });

    $('#cpfCnpj').val('');

    mostraCampo("cpfCnpj");
    escondeCampo("form-check-inscricaoEstadualPessoaFisica");
    escondeCampo("genero");
    escondeCampo("dataNascimento");
    mostraCampo("form-check-isento");
    mostraCampo("inscricaoEstadual");
}

function EsconderTodos() {
    escondeCampo("cpfCnpj");
    escondeCampo("form-check-inscricaoEstadualPessoaFisica");
    escondeCampo("genero");
    escondeCampo("dataNascimento");
    escondeCampo("cnpj");
    escondeCampo("form-check-isento");
    escondeCampo("inscricaoEstadual");
}

function escondeCampo(id) {
    $(`label[for="${id}"]`).addClass("d-none")
    $(`#${id}`).addClass("d-none")
}

function mostraCampo(id) {
    $(`label[for="${id}"]`).removeClass("d-none")
    $(`#${id}`).removeClass("d-none")
}

function mostrarIscricaoEstadualPessoaFisica() {
    $('#inscricaoEstadualPessoaFisica').on('change', function () {
        if ($(this).prop('checked')) {
            mostraCampo("inscricaoEstadual");
        } else {
            escondeCampo("inscricaoEstadual");
        }
    });
}

function desabilitaIscricaoEstadual() {
    $('#isento').on('change', function () {
        const inscricaoEstadualInput = $('#inscricaoEstadual');

        if ($(this).prop('checked')) {
            inscricaoEstadualInput.val('');
            inscricaoEstadualInput.prop('disabled', true);
        } else {
            inscricaoEstadualInput.prop('disabled', false);
        }
    });
}

function validarSenha() {
    var senha = $("#senha").val();
    var confirmacao = $("#confirmacao").val();

    if (senha !== confirmacao) {
        const notyf = new Notyf({
            duration: 1000,
            position: {
                x: 'right',
                y: 'top',
            },
            types: [
                {
                    type: 'warning',
                    background: '#FFA500',
                    icon: {
                        className: 'material-icons',
                        tagName: 'i',
                        text: 'warning'
                    },
                    duration: 10000,
                    dismissible: true
                }
            ]
        });

        notyf.open({
            type: 'warning',
            message: 'As senhas não conferem!'
        });

        return false;
    }

    return true;
}

function defineCamposObrigatoriosPessoaFisica(obrigatorio) {
    $("#genero").prop("required", obrigatorio);
    $("#dataNascimento").prop("required", obrigatorio);
}