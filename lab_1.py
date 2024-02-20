import PySimpleGUI as sg
import io
from PIL import Image, ImageDraw

def main():
    # Описываем макет окна
    layout = [
        [sg.Button("Загрузить изображение")],
        [sg.Image(key="-IMAGE-")],
        [sg.Button("Оригинал"), sg.Button("bl"), sg.Button("r"), sg.Button("g"), sg.Button("b")],
        [sg.Image(key="-HISTOGRAM-")]
    ]

    # Создаем окно приложения
    window = sg.Window("Приложение с изображением", layout)

    while True:
        event, values = window.read()

        # Проверяем события
        if event == sg.WINDOW_CLOSED:
            break
        elif event == "Загрузить изображение":
            # Диалоговое окно для выбора файла
            filename = sg.popup_get_file("Выберите изображение")

            if filename:
                # Отображаем изображение
                image = Image.open(filename)
                image.thumbnail((400, 400))  # Масштабируем изображение, чтобы оно влезло в окно
                bio = io.BytesIO()
                image.save(bio, format="PNG")
                window["-IMAGE-"].update(data=bio.getvalue())
        elif event == "Оригинал":
            update_histogram(window, filename)
        elif event == "bl":
            image = Image.open(filename).convert("L")  # Преобразование в черно-белый формат
            update_image(window, image)
            update_histogram(window, image)
        elif event in ("r", "g", "b"):
            color_channel = event.lower()[0]  # Получаем первую букву цвета
            image = Image.open(filename)
            channel_image = image.split()[['r', 'g', 'b'].index(color_channel)]  # Извлечение нужного канала
            update_image(window, channel_image)
            update_histogram(window, channel_image)

    window.close()

def update_image(window, image):
    image.thumbnail((400, 400))
    bio = io.BytesIO()
    image.save(bio, format="PNG")
    window["-IMAGE-"].update(data=bio.getvalue())

def update_histogram(window, image):
    histogram = image.histogram()
    img = Image.new("RGB", (256, 150), "white")
    max_height = max(histogram)

    draw = ImageDraw.Draw(img)

if __name__ == "__main__":
    main()
