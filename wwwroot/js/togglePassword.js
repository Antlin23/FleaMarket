const passwordInput = document.getElementById('password');
const toggleButton = document.getElementById('togglePassword');
if (toggleButton != null) {
    toggleButton.addEventListener('click', () => {
        if (passwordInput.type === 'password') {
            passwordInput.type = 'text';
            toggleButton.innerHTML = '<i class="fa-solid fa-eye"></i>';
        } else {
            passwordInput.type = 'password';
            toggleButton.innerHTML = '<i class="fa-solid fa-eye-slash"></i>';
        }
    });
}