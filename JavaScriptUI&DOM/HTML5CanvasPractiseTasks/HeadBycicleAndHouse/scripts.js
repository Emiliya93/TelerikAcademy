var canvas = document.getElementById('the-canvas'),
    ctx = canvas.getContext('2d'),
    headCenterX = 150,
    headCenterY = 350,
    headRadius = 100,

    leftEyeCenterX = 100,
    leftEyeCenterY = 410,
    leftEyeRadius = 15,

    leftEyeFillCenterX = leftEyeCenterX + 210,
    leftEyeFillRadius = 12,

    rightEyeCenterX = 180,
    rightEyeCenterY = leftEyeCenterY,
    rightEyeRadius = leftEyeRadius,

    rightEyeFillCenterX = rightEyeCenterX + 400,
    rightEyeFillRadius = leftEyeFillRadius,

    noseStartX = 470,
    noseStartY = 420,
    noseEndY = noseStartY + 50,

    mouthCenterX = leftEyeCenterX + 450,
    mouthCenterY = noseEndY + 2200,
    mouthRadius = 100;

// Draw head
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#22545F';
ctx.lineWidth = 4;

ctx.save();

// Draw head
ctx.beginPath();

ctx.scale(1, 0.8);
ctx.arc(headCenterX, headCenterY, headRadius, 0, 2 * Math.PI);
ctx.fill();
ctx.stroke();

// Draw eyes
ctx.restore();
ctx.scale(1, 0.6);
ctx.moveTo(leftEyeCenterX + leftEyeRadius, leftEyeCenterY);
ctx.arc(leftEyeCenterX, leftEyeCenterY, leftEyeRadius, 0, 2 * Math.PI);

ctx.moveTo(rightEyeCenterX + rightEyeRadius, rightEyeCenterY);
ctx.arc(rightEyeCenterX, rightEyeCenterY, rightEyeRadius, 0, 2 * Math.PI);

ctx.fill();
ctx.stroke();

ctx.closePath();

// Draw filling inside eyes
ctx.beginPath();
ctx.restore();
ctx.fillStyle = '#22545F';
ctx.scale(0.3, 1);
ctx.moveTo(leftEyeFillCenterX, leftEyeCenterY);
ctx.arc(leftEyeFillCenterX, leftEyeCenterY, leftEyeFillRadius, 0, 2 * Math.PI);

ctx.moveTo(rightEyeFillCenterX, rightEyeCenterY);
ctx.arc(rightEyeFillCenterX, rightEyeCenterY, rightEyeFillRadius, 0, 2 * Math.PI);

ctx.fill();
ctx.stroke();

// Draw nose
ctx.restore();
ctx.moveTo(noseStartX, noseStartY);
ctx.lineTo(noseStartX - 50, noseEndY);
ctx.lineTo(noseStartX, noseEndY);
ctx.stroke();

// Draw mouth
ctx.scale(0.8, 0.2);
ctx.moveTo(mouthCenterX + mouthRadius, mouthCenterY);
ctx.arc(mouthCenterX, mouthCenterY, mouthRadius, 0, 2 * Math.PI);
ctx.stroke();